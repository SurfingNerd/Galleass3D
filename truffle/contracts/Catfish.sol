pragma solidity ^0.5.7;

/*

  https://galleass.io
  by Austin Thomas Griffith

  Catfish is a species of fish in Galleass.

*/


import './Galleasset.sol';
import './ERC677Token.sol';
import 'openzeppelin-solidity/contracts/token/ERC20/ERC20Mintable.sol';

contract Catfish is Galleasset, ERC20Mintable, ERC677Token {

  string public constant name = "Galleass Catfish";
  string public constant symbol = "G_CATFISH";
  bytes32 public constant image = "catfish";
  uint8 public constant decimals = 0;

  constructor(address _galleass) Galleasset(_galleass) public {
  }

}