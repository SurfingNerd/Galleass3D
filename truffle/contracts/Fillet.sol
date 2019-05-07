pragma solidity ^0.5.7;

/*

  https://galleass.io
  by Austin Thomas Griffith

  A fillet is produced when a fishmonger butchers a fish. It is used to feed
  citizens and is the first type of food introduced to Galleass.

*/

import './Galleasset.sol';
import './ERC677Token.sol';
import 'openzeppelin-solidity/contracts/token/ERC20/ERC20Mintable.sol';


contract Fillet is Galleasset, ERC20Mintable, ERC677Token {

  string public constant name = "Galleass Fillet";
  string public constant symbol = "G_FILLET";
  uint8 public constant decimals = 0;

  constructor(address _galleass) Galleasset(_galleass) public {
  }
}
