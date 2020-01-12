pragma solidity ^0.5.7;

/*

  https://galleass.io
  by Austin Thomas Griffith

  Timber is harvested from forest tiles and used to build ships and buildings.

*/

import './Galleasset.sol';
import './ERC677Token.sol';
import 'openzeppelin-solidity/contracts/token/ERC20/ERC20Mintable.sol';

contract Timber is Galleasset, ERC20Mintable, ERC677Token {

  string public constant name = "Galleass Timber";
  string public constant symbol = "G_TIMBER";
  uint8 public constant decimals = 0;

  constructor(address _galleass) public Galleasset(_galleass) {
  }


}
