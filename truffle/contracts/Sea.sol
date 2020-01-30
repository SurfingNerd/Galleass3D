pragma solidity ^0.5.7;

/*

  https://galleass.io
  by Austin Thomas Griffith

  The Sea enables seaworth ships to travel from one island to another

*/

import './Galleasset.sol';
import './NFT.sol';

contract Sea is Galleasset {

  constructor(address _galleass) public Galleasset(_galleass) { }

  uint8 updateNonce = 0;
  event ShipUpdate(uint256 timestamp,uint256 id,address contractAddress,address indexed owner,bool floating,bool sailing,uint16 indexed x,uint16 indexed y,uint16 location,uint16 destX,uint16 destY,uint16 destLocation,uint16 destBlock);
  function emitShipUpdate(address _contract, uint _shipId,address _owner,Ship storage thisShip) internal {
    emit ShipUpdate(now,_shipId,_contract,_owner,thisShip.floating,thisShip.sailing,thisShip.x,thisShip.y,thisShip.location,thisShip.destX,thisShip.destY,thisShip.destLocation,thisShip.destBlock);
  }

  struct Ship{
    uint256 id;
    address contractAddress;
    address owner;
    bool floating;
    bool sailing;
    uint16 x;
    uint16 y;
    uint16 location;
    uint16 destX;
    uint16 destY;
    uint16 destLocation;
    uint16 destBlock;
  }

  //      ship contract      //ship id
  mapping(address => mapping(uint => Ship)) public ships;

  //
  // put a ship into the sea
  //
  function embark(address _contract, uint256 _shipId, uint16 _x, uint16 _y, uint16 _location) public isGalleasset("Sea") returns (bool) {
    //cant already be floating
    require( !ships[_contract][_shipId].floating );
    //make sure calling contract has permission to put the ship into the sea
    require(hasPermission(msg.sender,"embarkShips"));

    //initialize the ship storage
    Ship storage thisShip = ships[_contract][_shipId];
    thisShip.id = _shipId;
    thisShip.contractAddress = _contract;
    thisShip.floating=true;
    thisShip.sailing=false;
    thisShip.x=_x;
    thisShip.y=_y;
    thisShip.location=_location;

    NFT shipContract = NFT(_contract);
    address owner = shipContract.ownerOf(_shipId);

    emitShipUpdate(_contract,_shipId,owner,thisShip);
    return true;
  }