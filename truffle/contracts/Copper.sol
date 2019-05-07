pragma solidity ^0.5.7;

/*

  https://galleass.io
  by Austin Thomas Griffith

  Copper is the main currency in Galleass.

  It is considered a "hard" asset versus "soft" assets like Timber
    where some contracts have full permission to move them around
    it is a better store of value, but it can still be minted 

*/

import './Galleasset.sol';
import './ERC677Token.sol';
import 'openzeppelin-solidity/contracts/token/ERC20/ERC20Mintable.sol';

contract Copper is Galleasset, ERC20Mintable, ERC677Token {

  string public constant name = "Galleass Copper";
  string public constant symbol = "G_COPPER";
  uint8 public constant decimals = 0;

  constructor(address _galleass) Galleasset(_galleass) public {
  }

}
