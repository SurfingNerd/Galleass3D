pragma solidity ^0.4.15;

/*

  https://galleass.io
  by Austin Thomas Griffith

  The Land contract tracks all the procedurally generated islands in Galleass.

  Tiles can be purchased and built upon.

*/

import './Galleasset.sol';
import './DataParser.sol';
import './Citizens.sol';
import './CitizensLib.sol';
import './Land.sol';
import './StandardTokenInterface.sol';
import './StandardTile.sol';


contract LandLib is Galleasset, DataParser {

  uint public constant OPENLANDTILECOST = 5;

  mapping (bytes32 => uint16) public tileTypes;

  constructor(address _galleass) public Galleasset(_galleass) {
    //this is mainly just for human reference and to make it easier to track tiles mentally
    //it's expensive and probably won't be included in production contracts
    tileTypes["Water"]=0;

    tileTypes["MainHills"]=1;
    tileTypes["MainGrass"]=2;
    tileTypes["MainStream"]=3;

    tileTypes["Grass"]=50;
    tileTypes["Forest"]=51;
    tileTypes["Mountain"]=52;
    tileTypes["CopperMountain"]=53;
    tileTypes["SilverMountain"]=54;

    tileTypes["Harbor"]=100;
    tileTypes["Fishmonger"]=101;
    tileTypes["Market"]=102;

    tileTypes["TimberCamp"]=150;

    tileTypes["Village"]=2000;
    tileTypes["Castle"]=2010;
  }
  function () public {revert();}

  function setTileType(uint16 _tile,bytes32 _name) onlyOwner isBuilding public returns (bool) {
    tileTypes[_name] = _tile;
  }

  uint256 public nonce=0;

  function generateLand() onlyOwner isBuilding public returns (bool) {
    Land landContract = Land(getContract("Land"));
    //islands are procedurally generated based on a randomish hash
    bytes32 id = keccak256(nonce++,blockhash(block.number-1));
    uint16 x = uint16(id[0]) << 8 | uint16(id[1]);
    uint16 y = uint16(id[2]) << 8 | uint16(id[3]);
    bytes32 landParts1 = keccak256(id);
    bytes32 landParts2 = keccak256(landParts1);

    //don't allow land at 0's (those are viewed as empty)
    if(x==0) x=1;
    if(y==0) y=1;

    //GAS USAGE AT THIS POINT --- 50k vvvvvvvvv EXPENSIVE vvvvvvvv
    setTilesAndOwners(x,y,landContract,landParts1,landParts2);
    //GAS USAGE AT THIS POINT ---   900k ^^^^^^ EXPENSIVE ^^^^^^^^^

    //scan tiles and insert base spots
    uint8 landCount = 0;
    for(uint8 landex = 0; landex < 18; landex++){
      if(landContract.tileTypeAt(x,y,landex)==0){
        if(landCount>0){
          //right edge
          landContract.setTileTypeAt(x,y,landex-(landCount%2+landCount/2),1);//MAIN TITLE
          landCount=0;
        }
      }else{
        if(landCount==0){
          //left edge
        }
        landCount++;
      }
    }
    if(landCount>0){
      //final right edge
      landContract.setTileTypeAt(x,y,17-(landCount/2),1);//MAIN TITLE
      landCount=0;
    }

    if(landContract.mainX()==0||landContract.mainY()==0){
      landContract.setMainLocation(x,y);
    }

    landContract.setTotalWidth(x,y,getTotalWidth(x,y));
  }

  function setTilesAndOwners(uint16 x,uint16 y,Land landContract,bytes32 landParts1, bytes32 landParts2)
  public
  {
    uint8[9] memory islands;
    uint8 tileCountPerIsland = 0;
    uint8 currentIslandCount = 0;
    for(uint8 index = 0; index < 18; index++){
      uint16 thisUint16 = uint16(landParts1[index]) << 8 | uint16(landParts2[index]);
      uint16 tileType = translateToStartingTile(thisUint16);
      landContract.setTileTypeAt(x,y,index,tileType);
      //landContract.setOwnerAt(x,y,index,msg.sender);
      if(tileType==0){
        if(tileCountPerIsland>0){
          islands[currentIslandCount++] = tileCountPerIsland;
          tileCountPerIsland=0;
        }
      }else{
        tileCountPerIsland++;
      }
    }
    if(tileCountPerIsland>0){
      islands[currentIslandCount++] = tileCountPerIsland;
    }
    /*while(currentIslandCount<9){
      islands[currentIslandCount++]=0;
    }*/
    landContract.signalGenerateLand(x,y,islands);
  }
  event Debug(uint8 currentIslandCount,uint8 tileCountPerIsland);


  function getTotalWidth(uint16 _x,uint16 _y) public constant returns (uint16){
    Land landContract = Land(getContract("Land"));
    uint16 totalWidth = 0;
    bool foundLand = false;
    for(uint8 t = 0;t<18;t++){
      uint16 tileType = landContract.tileTypeAt(_x,_y,t);
      totalWidth+=translateTileToWidth(tileType);
      if(tileType!=0&&!foundLand){
        foundLand=true;
        totalWidth+=114;
      }else if(tileType==0&&foundLand){
        foundLand=false;
        totalWidth+=114;
      }
    }
    if(foundLand) totalWidth+=114;
    return totalWidth;
  }

  //erc677 receiver
  function onTokenTransfer(address _sender, uint _amount, bytes _data) public isGalleasset("LandLib") returns (bool) {
    TokenTransfer(msg.sender,_sender,_amount,_data);
    uint8 action = uint8(_data[0]);
    if(action==1){
      return _buyTile(_sender,_amount,_data);
    } else if(action==2){
      return _buildTimberCamp(_sender,_amount,_data);
    } else if(action==3){
      return _extractRawResource(_sender,_amount,_data);
    } else if(action==3){
      return _extractRawResource(_sender,_amount,_data);
    }
    return false;
  }
  event TokenTransfer(address token,address sender,uint amount,bytes data);

  function _buyTile(address _sender, uint _amount, bytes _data) internal returns (bool) {
    Land landContract = Land(getContract("Land"));
    address copperContractAddress = getContract("Copper");
    require(msg.sender == copperContractAddress);
    uint16 _x = getX(_data);
    uint16 _y = getY(_data);
    uint8 _tile = getTile(_data);
    StandardTokenInterface copperContract = StandardTokenInterface(copperContractAddress);
    if(landContract.ownerAt(_x,_y,_tile)==address(0)){
      //must send at least BLANK LAND TILE COST
      require(_amount>=OPENLANDTILECOST);
      //transfer the copper to the Land Contract
      require(copperContract.transfer(landContract,OPENLANDTILECOST));
    }else{
      //must be for sale
      require(landContract.priceAt(_x,_y,_tile)>0);
      //must send at least enough as the price
      require(_amount>=landContract.priceAt(_x,_y,_tile));
      //transfer the copper to the Land Owner
      require(copperContract.transfer(landContract.ownerAt(_x,_y,_tile),_amount));
    }
    //set the new owner to the sender
    landContract.setOwnerAt(_x,_y,_tile,_sender);
    //when a piece of land is purchased, an "onPurchase" function is called
    // on the contract to help the inner contract track events and owners etc
    if(landContract.contractAt(_x,_y,_tile)!=address(0)){
      StandardTile tileContract = StandardTile(landContract.contractAt(_x,_y,_tile));
      tileContract.onPurchase(_x,_y,_tile,landContract.ownerAt(_x,_y,_tile),landContract.priceAt(_x,_y,_tile));
    }
    //clear the price so it isn't for sale anymore
    landContract.setPriceAt(_x,_y,_tile,0);
    return true;
  }

  function buildTile(uint16 _x, uint16 _y,uint8 _tile,uint16 _newTileType) public isGalleasset("LandLib") returns (bool) {
    Land landContract = Land(getContract("Land"));
    //must be the owner of the tile to build here
    require(msg.sender==landContract.ownerAt(_x,_y,_tile));
    //get the current type of tile here to see what can be built on it
    uint16 tileType = landContract.tileTypeAt(_x,_y,_tile);
    if(tileType==tileTypes["MainHills"]||tileType==tileTypes["MainGrass"]){
      //they want to build on a main, blank spot whether hills or grass
      if(_newTileType==tileTypes["Village"]){
        //require( getTokens(msg.sender,"Timber",6) );
        StandardTokenInterface timberContract = StandardTokenInterface(getContract("Timber"));
        require( timberContract.galleassTransferFrom(msg.sender,getContract("Land"),6) ); //use 6 timber (moved to Land contract)
        //set tile type on the Land Contract
        landContract.setTileTypeAt(_x,_y,_tile,_newTileType);
        //set contract at tile to the Village
        address villageContract = getContract("Village");
        landContract.setContractAt(_x,_y,_tile,villageContract);
        //trigger the onPurchase for the contract (this is used for land contracts to track owners and initialize)
        StandardTile(villageContract).onPurchase(_x,_y,_tile,msg.sender,0);
        return true;
      }else{
        return false;
      }
    } else if(tileType==tileTypes["Village"]){
      //they want to build on a main, blank spot whether hills or grass
      if(_newTileType==tileTypes["Castle"]){
        //require( getTokens(msg.sender,"Timber",6) );
        StandardTokenInterface stoneContract = StandardTokenInterface(getContract("Stone"));
        require( stoneContract.galleassTransferFrom(msg.sender,getContract("Land"),20) ); //use 20 stone (moved to Land contract)
        //set tile type on the Land Contract
        landContract.setTileTypeAt(_x,_y,_tile,_newTileType);
        //set contract at tile to the Village
        address castleContract = getContract("Castle");
        landContract.setContractAt(_x,_y,_tile,castleContract);
        //trigger the onPurchase for the contract (this is used for land contracts to track owners and initialize)
        StandardTile(castleContract).onPurchase(_x,_y,_tile,msg.sender,0);
        return true;
      }else{
        return false;
      }
    } else {
      return false;
    }
  }

  function _buildTimberCamp(address _sender, uint _amount, bytes _data) internal returns (bool) {
    Land landContract = Land(getContract("Land"));
    //build timber camp
    address copperContractAddress = getContract("Copper");
    require(msg.sender == copperContractAddress);
    uint16 _x = getX(_data);
    uint16 _y = getY(_data);
    uint8 _tile = getTile(_data);

    //they must own the tile
    require(landContract.ownerAt(_x,_y,_tile)==_sender);
    //they must send in 6 copper
    require(_amount>=6);
    //move that copper to the Land contract
    StandardTokenInterface copperContract = StandardTokenInterface(copperContractAddress);
    require(copperContract.transfer(getContract("Land"),_amount));
    //must be built on a forest tile
    require(landContract.tileTypeAt(_x,_y,_tile)==tileTypes["Forest"]);


    //assuming the we used the fist 6 bytes of the data for action,x,y,tile we will use the rest as the id of
    // the citizen that will be building the timber camp
    uint citizenId = uint(getRemainingBytesLeadingZs(6,_data));
    //uint citizenId = getRemainingUint(6,_data);

    //make sure that this address owns a citizen at this location with strength and stamina > 1
    // if everything is right, set the status to timber camp
    require(_useCitizenAsLumberjack(_sender,_x,_y,_tile,citizenId));
    //set new tile type
    landContract.setTileTypeAt(_x,_y,_tile,tileTypes["TimberCamp"]);

    //Debug(getContract("TimberCamp"));
    //set contract to timber camp
    landContract.setContractAt(_x,_y,_tile,getContract("TimberCamp"));
    StandardTile tileContract = StandardTile(landContract.contractAt(_x,_y,_tile));
    tileContract.onPurchase(_x,_y,_tile,landContract.ownerAt(_x,_y,_tile),landContract.priceAt(_x,_y,_tile));

    return true;
  }
  //event Debug(bytes32 citizenBytes,uint8 b,uint8 d, bytes32 thisByte);

  function _useCitizenAsLumberjack(address _sender, uint16 _x, uint16 _y, uint8 _tile,uint _citizen) internal returns (bool){
    Citizens citizensContract = Citizens(getContract("Citizens"));
    address owner;
    uint8 status;
    uint16 x;
    uint16 y;
    uint8 tile;
    bytes32 characteristics;
    (owner,status,,x,y,tile,,characteristics,) = citizensContract.getToken(_citizen);
    //sender must own citizen
    require(owner==_sender);
    //citizen must be idle
    require(status==1);
    //citizen must be at location
    require(_x==x);
    require(_y==y);
    require(_tile==tile);
    //citizen must have enough strength and stamina to be a lumberjack
    CitizensLib citizensLibContract = CitizensLib(getContract("CitizensLib"));
    uint16 strength;
    uint16 stamina;
    (strength,stamina,,,,,,) = citizensLibContract.getCitizenCharacteristics(_citizen);
    require(strength>1);
    require(stamina>1);
    //set citizen status to TimberCamp tile type (lumberjack!)
    require(citizensLibContract.setStatus(_citizen,uint8(tileTypes["TimberCamp"])));
    return true;
  }

  function _extractRawResource(address _sender, uint _amount, bytes _data) internal returns (bool) {
    Land landContract = Land(getContract("Land"));
    address copperContractAddress = getContract("Copper");
    require(msg.sender == copperContractAddress);

    uint16 _x = getX(_data);
    uint16 _y = getY(_data);
    uint8 _tile = getTile(_data);

    //they must own the tile
    require(landContract.ownerAt(_x,_y,_tile)==_sender);
    //move that copper to the Land contract
    StandardTokenInterface copperContract = StandardTokenInterface(copperContractAddress);
    require(copperContract.transfer(getContract("Land"),_amount));
    StandardTokenInterface resourceContract;

    if(landContract.tileTypeAt(_x,_y,_tile)==tileTypes["Forest"] || landContract.tileTypeAt(_x,_y,_tile)==tileTypes["TimberCamp"]){
      //they must send in 3 copper to extract 1 Timber
      require(_amount>=3);
      resourceContract = StandardTokenInterface(getContract("Timber"));
      require(resourceContract.galleassMint(_sender,1));
      return true;
    } else if(landContract.tileTypeAt(_x,_y,_tile)==tileTypes["Grass"] || landContract.tileTypeAt(_x,_y,_tile)==tileTypes["MainGrass"]){
      //they must send in 2 copper to extract 1 Greens
      require(_amount>=2);
      resourceContract = StandardTokenInterface(getContract("Greens"));
      require(resourceContract.galleassMint(_sender,1));
      return true;
    } else if(landContract.tileTypeAt(_x,_y,_tile)==tileTypes["Mountain"]) {
      //they must send in 4 copper to extract 1 Stone
      require(_amount>=4);
      resourceContract = StandardTokenInterface(getContract("Stone"));
      require(resourceContract.galleassMint(_sender,1));
      return true;
    }else{
      return false;
    }
  }

  function translateTileToWidth(uint16 _tileType) public constant returns (uint16) {
    if(_tileType==tileTypes["Water"]){
      return 95;
    }else if (_tileType>=1&&_tileType<50){
      return 120;
    }else if (_tileType>=50&&_tileType<100){
      return 87;
    }else if (_tileType>=100&&_tileType<150){
      return 120;
    }else if (_tileType>=150&&_tileType<200){
      return 87;
    }else{
      return 120;
    }
  }

  function translateToStartingTile(uint16 tilepart) public constant returns (uint16) {
    if(tilepart<12850){
      return tileTypes["Water"];
    }else if(tilepart<19275){
      return tileTypes["MainHills"];
    }else if(tilepart<24415){
      return tileTypes["MainGrass"];
    }else if(tilepart<26985){
      return tileTypes["MainStream"];
    }else if(tilepart<40606){
      return tileTypes["Grass"];
    }else if(tilepart<59624){
      return tileTypes["Forest"];
    }else if(tilepart<64250){
      return tileTypes["Mountain"];
    }else if(tilepart<65287){
      return tileTypes["CopperMountain"];
    }else{
      return tileTypes["SilverMountain"];
    }
  }

}