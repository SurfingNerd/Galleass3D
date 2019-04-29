pragma solidity ^0.4.15;

/*

  https://galleass.io
  by Austin Thomas Griffith & Thomas Haller

  Catfish is a species of fish in Galleass.

*/

import './Galleasset.sol';
import './ERC677Token.sol';
import 'openzeppelin-solidity/contracts/token/ERC20/MintableToken.sol';

contract Catfish is Galleasset, MintableToken, ERC677Token {

  string public constant name = "Galleass Catfish";
  string public constant symbol = "G_CATFISH";
  bytes32 public constant image = "catfish";
  uint8 public constant decimals = 0;


  uint256 public constant INITIAL_SUPPLY = 0;

  constructor(address _galleass) Galleasset(_galleass) public {
    totalSupply_ = INITIAL_SUPPLY;
  }

  function galleassTransferFrom(address _from, address _to, uint256 _value) public returns (bool) {
    require(_to != address(0));
    require(_value <= balances[_from]);
    require(hasPermission(msg.sender,"transferFish"));

    balances[_from] = balances[_from].sub(_value);
    balances[_to] = balances[_to].add(_value);
    Transfer(_from, _to, _value);
    return true;
  }

}
