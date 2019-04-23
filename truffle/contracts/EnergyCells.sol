pragma solidity ^0.5.2;

import 'openzeppelin-solidity/contracts/token/ERC20/ERC20Mintable.sol';

contract EnergyCell is ERC20Mintable {

  string public constant name = "Energy Cell";
  string public constant symbol = "EC";
  bytes32 public constant image = "energycell";
  uint8 public constant decimals = 18;

  uint256 public constant INITIAL_SUPPLY = 0;

  constructor() public {
    //totalSupply = INITIAL_SUPPLY;
  }
}