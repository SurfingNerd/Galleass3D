pragma solidity ^0.5.7;

/*

  https://galleass.io
  by Austin Thomas Griffith

  The DataParser library is extended to help parse ERC677 data
  Usually you parse out the x,y,tile then, there is a field or two
   of arbitrary value, then you take the remaining bytes to get
   a dyanmic sized set of data for a while bytes32 or uint256
*/


contract DataParser {

  function getX(bytes memory _data) internal pure returns (uint16 _x) {
    bytes2 a = (bytes2)(_data[1]);
    bytes2 b = (bytes2)(_data[2]);

    a = a << 8;
    return (uint16)(a) + (uint16)(b);
    //return uint16(_data[1] << 8 | uint16(_data[2]));
  }

  function getY(bytes memory _data) internal pure returns (uint16 _y){
    //return uint16(_data[3]) << 8 | uint16(_data[4]);
    bytes2 a = (bytes2)(_data[3]);
    bytes2 b = (bytes2)(_data[4]);

    a = a << 8;
    return (uint16)(a) + (uint16)(b);
  }

  function getTile(bytes memory _data) internal pure returns (uint8 _tile){
    return uint8(_data[5]);
  }

  function getRemainingBytesLeadingZs(uint8 _offset, bytes memory _data) internal pure returns (bytes32 result){
    uint8 b = 31;
    uint8 d = uint8(_data.length-1);
    while(d>_offset-1){
      result |= bytes32(_data[d--] & 0xFF) >> (b-- * 8);
    }
    return result;
  }


  function getRemainingBytesTrailingZs(uint _offset,bytes memory _data) internal pure returns (bytes32 result) {
    for (uint i = 0; i < 32; i++) {
      uint8 adjusted = uint8(_offset + i);
      if(adjusted<_data.length){
          result |= bytes32(_data[adjusted] & 0xFF) >> (i * 8);
      }else{
          result |= bytes32(0x00) >> (i * 8);
      }
    }
    return result;
  }

  function getRemainingUint(uint8 _offset,bytes memory _data) internal pure returns (uint) {
    uint result = 0;
    uint endsAt = _data.length;
    uint8 d = uint8(endsAt-1);
    while(d>_offset-1){
      uint c = uint((bytes32)(_data[d]));
      uint to_inc = c * ( 16 ** ((endsAt - d-1) * 2));
      result += to_inc;
      d--;
    }
    return result;
  }

  function getAddressFromBytes(uint8 _offset,bytes memory _data) internal pure returns (address) {
    uint result = 0;
    uint endsAt = _offset+20;
    uint8 d = uint8(endsAt-1);
    while(d>_offset-1){
      uint c = uint((bytes32)(_data[d]));
      uint to_inc = c * ( 16 ** ((endsAt - d-1) * 2));
      result += to_inc;
      d--;
    }
    return address(result);
  }
}
