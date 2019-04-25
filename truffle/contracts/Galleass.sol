pragma solidity ^0.4.18;

/*

  https://galleass.io
  by Austin Thomas Griffith

  The Galleass contract contains a reference to all contracts in the fleet and
  provides a method of upgrading/replacing old contract versions.

  Galleass follows a Predecessor system where previous deployments of this
  contract will forward on to their decendants.

  Galleass contains an authentication system where contracts are allowed to do
  specific actions based on the permissions they are assigned.

  Finally, there is the notion of building, staging, and production modes. Once
  the contract is set to production, it is fully decentralized and not even the
  owner account can make changes.

*/



import 'openzeppelin-solidity/contracts/ownership/Contactable.sol';
import './Staged.sol';
import './Predecessor.sol';
import './Galleasset.sol';
import './StandardTokenInterface.sol';


contract Galleass is Staged, Contactable, Predecessor{

  string public constant name = "Galleass";
  string public constant author = "Thomas Haller thomas.haller@lab10.io";

  event UpgradeContract(address _contractAddress,address _descendant,address _whoDid);
  event SetContract(bytes32 _name,address _contractAddress,address _whoDid);
  event SetPermission(address _account,bytes32 _permission,bool _value);

  mapping(bytes32 => address) contracts;
  mapping(address => mapping(bytes32 => bool)) permission;

  constructor(string _contact) public { setContactInformation(_contact); }

  function upgradeContract(address _contract) onlyOwner isBuilding public returns (bool) {
    Galleasset(_contract).upgradeGalleass(descendant);
    emit UpgradeContract(_contract,descendant,msg.sender);
    return true;
  }

  function setContract(bytes32 _name,address _contract) onlyOwner isBuilding public returns (bool) {
    contracts[_name]=_contract;
    emit SetContract(_name,_contract,msg.sender);
    return true;
  }

  function setPermission(address _contract, bytes32 _permission, bool _value) onlyOwner isBuilding public returns (bool) {
    permission[_contract][_permission]=_value;
    emit SetPermission(_contract,_permission,_value);
    return true;
  }

  function getContract(bytes32 _name) public view returns (address) {
    if(descendant!=address(0)) {
      return Galleass(descendant).getContract(_name);
    }else{
      return contracts[_name];
    }
  }

  function hasPermission(address _contract, bytes32 _permission) public view returns (bool) {
    if(descendant!=address(0)) {
      return Galleass(descendant).hasPermission(_contract,_permission);
    }else{
      return permission[_contract][_permission];
    }
  }

  function withdraw(uint256 _amount) public onlyOwner returns (bool) {
    require(address(this).balance >= _amount);
    assert(owner.send(_amount));
    return true;
  }
  function withdrawToken(address _token,uint256 _amount) public onlyOwner returns (bool) {
    StandardTokenInterface token = StandardTokenInterface(_token);
    token.transfer(msg.sender,_amount);
    return true;
  }

}