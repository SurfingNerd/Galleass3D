pragma solidity ^0.5.7;

/*

  https://galleass.io
  by Austin Thomas Griffith

  The CitizensLib contract extends the logic for Citizens
  

*/

import './Galleasset.sol';
import './Land.sol';
import './Citizens.sol';

contract CitizensLib is Galleasset {

  uint8 nonce = 0;

  constructor(address _galleass) Galleasset(_galleass) public { }

  function ownerCreateCitizen(address owner,uint16 _x, uint16 _y, uint8 _tile,bytes32 genes, bytes32 characteristics) onlyOwner isBuilding public returns (uint){
    //function used at world build time to populate certain buildings like the fishmonger with a Citizen
    _createCitizen(owner,_x,_y,_tile,genes,characteristics);
  }

  function ownerSetStatus(uint _id,uint8 _status) onlyOwner isBuilding public returns (bool){
    Citizens citizensContract = Citizens(getContract("Citizens"));
    return citizensContract.setStatus(_id,_status);
  }

  //a citizen is created when food is provided to a village
  function createCitizen(address owner,uint16 _x, uint16 _y, uint8 _tile,bytes32 food1, bytes32 food2, bytes32 food3) public isGalleasset("CitizensLib") returns (uint){
    require(hasPermission(msg.sender,"createCitizens"));

    //eventually you will want to be able to use a standard contract interface

    bytes32 characteristics = _convertFoodToCharacteristics(owner,food1,food2,food3);

    //genes will at first be random but then maybe they will be mixed... like you might need
    //to not only have food, but a couple citizens in the village too and you would use
    //their existing genes to mix for the new genes
    bytes32 genes = keccak256(abi.encodePacked(blockhash(block.number-1), nonce++));

    //internal function to reduce stack size
    _createCitizen(owner,_x,_y,_tile,genes,characteristics);
  }

  function _createCitizen(address owner,uint16 _x,uint16 _y,uint8 _tile,bytes32 genes,bytes32 characteristics) internal {
    Citizens citizensContract = Citizens(getContract("Citizens"));
    citizensContract.createCitizen(owner,1,0,_x,_y,_tile,genes,characteristics);
  }

  function _convertFoodToCharacteristics(address owner,bytes32 food1,bytes32 food2,bytes32 food3) internal returns (bytes32 characteristics){
    /*
    i went back and forth for a while trying to decide if you send the fillet to the village
    then, this contract pulls from there. It's really cool to see the village contract "inventory"
    BUT, if there is a contract for every village then it would need to be deployed as a new one is built
    this deployment would have to come from the builder and you would have to trust it...
    ...maybe that is okay? Maybe the bytecode could be compared or something...
    ..I think I've decided against that, I think it makes more sense to have one contract for all of the villages.
    */
    if(food1=="Fillet"&&food2=="Fillet"&&food3=="Fillet"){
      /*require( getTokens(msg.sender,food1,1) );
      require( getTokens(msg.sender,food2,1) );
      require( getTokens(msg.sender,food3,1) );*/
      require(getTokens(owner,"Fillet",3), 'No Fillet available');
      //for now there are only fillets, eventually a complex funtion will take in the food and output the characteristics
      characteristics = 0x0002000200000000000000000000000000000000000000000000000000000000;
    } else if(food1=="Greens"&&food2=="Fillet"&&food3=="Fillet"){
      /*require( getTokens(msg.sender,food1,1) );
      require( getTokens(msg.sender,food2,1) );
      require( getTokens(msg.sender,food3,1) );*/
      require(getTokens(owner,"Greens",1), "No Greens available");
      require(getTokens(owner,"Fillet",2), "No Fillet available");
      //for now there are only fillets, eventually a complex funtion will take in the food and output the characteristics
                       // str|sta|dex|int|amb|rig|ind|ing|
      characteristics = 0x0001000200010005000100000000000100000000000000000000000000000000;
    }else{
      revert("unknown recipe");
    }

    return characteristics;
  }


  function getUint16(bytes1 data1, bytes1 data2)
  internal
  pure
  returns (uint16 _x) {
    bytes2 a = (bytes2)(data1);
    bytes2 b = (bytes2)(data2);

    a = a << 8;
    return (uint16)(a) + (uint16)(b);
    //return uint16(_data[1] << 8 | uint16(_data[2]));
  }

  function getCitizenGenes(uint256 _id) public view returns (uint16 head,uint16 hair,uint16 eyes,uint16 nose,uint16 mouth) {
    Citizens citizensContract = Citizens(getContract("Citizens"));
    bytes32 genes;
    (,,,,,,genes,,) = citizensContract.getToken(_id);
    head = getUint16(genes[0], genes[1]);
    hair = getUint16(genes[2], genes[3]);
    eyes = getUint16(genes[4], genes[5]);
    nose = getUint16(genes[6], genes[7]);
    mouth = getUint16(genes[8], genes[9]);
    return (head,hair,eyes,nose,mouth);
  }

  function getCitizenCharacteristics(uint256 _id)
  public
  view
  returns (uint16 strength,uint16 stamina,uint16 dexterity,uint16 intelligence,uint16 ambition,uint16 rigorousness,uint16 industriousness,uint16 ingenuity) {
    Citizens citizensContract = Citizens(getContract("Citizens"));
    bytes32 characteristics;
    (,,,,,,,characteristics,) = citizensContract.getToken(_id);
    strength = getUint16(characteristics[0], characteristics[1]);
    stamina = getUint16(characteristics[2], characteristics[3]);
    dexterity = getUint16(characteristics[4], characteristics[5]);
    intelligence = getUint16(characteristics[6], characteristics[7]);
    ambition = getUint16(characteristics[8], characteristics[9]);
    rigorousness = getUint16(characteristics[10], characteristics[11]);
    industriousness = getUint16(characteristics[12], characteristics[13]);
    ingenuity = getUint16(characteristics[14], characteristics[15]);
    return (strength, stamina, dexterity, intelligence, ambition, rigorousness, industriousness, ingenuity);
  }

  function getCitizenStatus(uint256 _id) public view returns (uint8 status,uint16 x, uint16 y, uint8 tile,uint data) {
    Citizens citizensContract = Citizens(getContract("Citizens"));
    (,status,data,x,y,tile,,,) = citizensContract.getToken(_id);
    return (status,x,y,tile,data);
  }

  function setStatus(uint _id,uint8 _status) public isGalleasset("CitizensLib") returns (bool){
    require(hasPermission(msg.sender,"useCitizens"), 'missing useCitizens permission');
    Citizens citizensContract = Citizens(getContract("Citizens"));
    return citizensContract.setStatus(_id,_status);
  }

  //citizens should be bought and sold for ether
  function setPrice(uint _id,uint _price) public isGalleasset("CitizensLib") returns (bool){
    Citizens citizensContract = Citizens(getContract("Citizens"));
    uint8 status;
    address owner;
    (owner,status,,,,,,,) = citizensContract.getToken(_id);
    //you must own the citizen to set its sale price
    require(owner==msg.sender, 'must be owner');
    //the citizen must be idle or for sale to go on sale
    require(status==1||status==2, 'status must be 1 or 2');
    //is it currently for sale?
    if(_price==0){
      //setting the price to 0 means not for sale any more
      require(citizensContract.setStatus(_id,1), 'it is not for sale');
    }else{
      //set status to 2 (for sale)
      require(citizensContract.setStatus(_id,2), 'could not set status for sale');
    }
    //set citizen data to the price
    require(citizensContract.setData(_id,_price), 'could not sent price');
    return true;
  }

  function moveCitizen(uint _id,uint8 _tile) public isGalleasset("CitizensLib") returns (bool) {
    
    Citizens citizensContract = Citizens(getContract("Citizens"));
    bytes32 dummyGenes;
    bytes32 dummyCharacteristics;
    uint64 dummyBirth;
    uint8 status;
    address owner;
    uint256 dummyData;
    uint16 x;
    uint16 y;
    uint8 tile;
    (owner,status,dummyData,x,y,tile,dummyGenes,dummyCharacteristics, dummyBirth) = citizensContract.getToken(_id);
    //you must own the citizen to move them
    require(owner==msg.sender, 'Only Owner');
    //the citizen must be idle to move
    require(status==1, 'Status must be 1');
    //you must own all the land between the current location and the destination
    //(bascially they will walk at the speed of light at first, but eventually
    // there should probably be some sort of transportation per island and it
    // takes a varying amount of time to move from tile to tile)
    Land landContract = Land(getContract("Land"));
    //first let's just make sure they own the dest and build the other stuff in
    //maybe it's fine for them to move anywhere on local islands at first idk
    //destination can't be water
    require(landContract.tileTypeAt(x,y,_tile)>0, 'destination cant be water');
    //must own destination
    require(landContract.ownerAt(x,y,_tile)==msg.sender, 'must own destination');
    //you can't already be at the destination
    require(tile!=_tile, 'you cant already be at the destination');
    //set the tile on the Citisen contract
    require(citizensContract.setTile(_id,_tile), 'failed: set the tile on the Citisen contract');
    return true;
  }
  event Debug(uint _id,uint8 _tile,uint8 status,address owner);

}


