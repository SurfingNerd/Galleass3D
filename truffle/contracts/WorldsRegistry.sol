pragma solidity ^0.5.7;

import 'openzeppelin-solidity/contracts/ownership/Ownable.sol';
//import './Galleas.sol';

contract WorldsRegistry is Ownable {

    mapping(bytes32 => address) public worlds;

    bytes32 public lastCreatedWorldName;
    address public lastCreatedWorldsAddress;

    //bytes32[][] public worldNames;
    //event SetPermission(address _account,bytes32 _permission,bool _value);
    event GalleasWorldRegistered(address galeassContract, bytes32 indexed name, uint timestamp);

    function registerGalleasWorld(address galleasContract, bytes32 name)
    public
    onlyOwner
    returns (bool)
    {
        //todo: how to verify that galleasContract is a real galleasContract ?
        //require(worlds[name] == 0, 'A World with this name already exists!');
        lastCreatedWorldName = name;
        lastCreatedWorldsAddress = galleasContract;
        worlds[name] = galleasContract;
        emit GalleasWorldRegistered(galleasContract, name, block.timestamp);

        return true;
    }
}