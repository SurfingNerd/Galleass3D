pragma solidity ^0.4.15;

/*

  https://galleass.io
  by Austin Thomas Griffith

  The Village is where food is consumed and citizens are created

*/

import './StandardTile.sol';
import './CitizensLib.sol';

contract Village is StandardTile {

  constructor(address _galleass) public StandardTile(_galleass) { }

  function createCitizen(uint16 _x,uint16 _y,uint8 _tile,bytes32 food1, bytes32 food2, bytes32 food3) public isGalleasset("Village") isLandOwner(_x,_y,_tile) returns (uint) {
    //use an internal function because the stack is too deep
    return _createCitizen(_x,_y,_tile,food1,food2,food3);
  }

  function _createCitizen(uint16 _x,uint16 _y,uint8 _tile,bytes32 food1, bytes32 food2, bytes32 food3) internal returns (uint) {
    CitizensLib citizensContract = CitizensLib(getContract("CitizensLib"));
    return citizensContract.createCitizen(msg.sender,_x,_y,_tile,food1,food2,food3);
  }
}