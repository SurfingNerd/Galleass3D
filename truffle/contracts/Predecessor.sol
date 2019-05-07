pragma solidity ^0.5.7;

import './Staged.sol';

contract Predecessor is Staged{
    constructor () public {}
    address public descendant;
    function setDescendant(address _descendant) onlyOwner isNotProduction public {
      descendant=_descendant;
    }
    modifier hasNoDescendant() {
      require(descendant == address(0));
      _;
    }
}
