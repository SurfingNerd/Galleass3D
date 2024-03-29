pragma solidity ^0.5.7;

import 'openzeppelin-solidity/contracts/token/ERC20/ERC20.sol';

// adapted from https://github.com/ethereum/EIPs/issues/677
//    big thanks to Steve Ellis

contract ERC677Token is ERC20 {

  event TransferAndCall(address indexed from, address indexed to, uint value, bytes data);

  function transferAndCall(address _to, uint _value, bytes memory _data)
    public
    validRecipient(_to)
    returns (bool success)
  {
    super.transfer(_to, _value);
    emit TransferAndCall(msg.sender, _to, _value, _data);
    if (isContract(_to)) {
      contractFallback(_to, _value, _data);
    }
    return true;
  }
  function contractFallback(address _to, uint _value, bytes memory _data)
    validRecipient(_to)
    private
    view
  {
    ERC677Receiver receiver = ERC677Receiver(_to);
    require(receiver.onTokenTransfer(msg.sender, _value, _data));
  }

  function isContract(address _addr)
    private view
    returns (bool hasCode)
  {
    uint length;
    assembly { length := extcodesize(_addr) }
    return length > 0;
  }


  modifier validRecipient(address _recipient) {
    require(_recipient != address(0) && _recipient != address(this));
    _;

  }

}

contract ERC677Receiver {
  function onTokenTransfer(address /*_sender*/, uint /*_value*/, bytes memory /*_data*/) public pure returns (bool){}
}
