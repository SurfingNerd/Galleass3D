pragma solidity ^0.5.7;

import 'openzeppelin-solidity/contracts/ownership/Ownable.sol';


contract Staged is Ownable {

  enum StagedMode {
    PAUSED,
    BUILD,
    STAGE,
    PRODUCTION
  }

  StagedMode public stagedMode;

  constructor() public {
    stagedMode=StagedMode.BUILD;
  }

  modifier isBuilding() {
    require(stagedMode == StagedMode.BUILD);
    _;
  }

  modifier isStaging() {
    require(stagedMode == StagedMode.STAGE);
    _;
  }

  modifier isNotProduction() {
    require(stagedMode != StagedMode.PRODUCTION);
    _;
  }

  modifier isNotPaused() {
    require(stagedMode != StagedMode.PAUSED);
    _;
  }

  function pause() isNotProduction onlyOwner public returns (bool) {
    stagedMode=StagedMode.PAUSED;
  }

  function stage() isNotProduction onlyOwner public returns (bool) {
    stagedMode=StagedMode.STAGE;
  }

  function build() isNotProduction onlyOwner public returns (bool) {
    stagedMode=StagedMode.BUILD;
  }

  function destruct() isNotProduction onlyOwner public returns (bool) {
    selfdestruct(owner);
  }

  function production() isStaging onlyOwner public returns (bool) {
    stagedMode=StagedMode.PRODUCTION;
  }

}

