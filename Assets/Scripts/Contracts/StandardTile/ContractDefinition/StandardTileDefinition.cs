using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts;
using System.Threading;

namespace Galleass3D.Contracts.StandardTile.ContractDefinition
{


    public partial class StandardTileDeployment : StandardTileDeploymentBase
    {
        public StandardTileDeployment() : base(BYTECODE) { }
        public StandardTileDeployment(string byteCode) : base(byteCode) { }
    }

    public class StandardTileDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b5060405161112b38038061112b8339818101604052602081101561003357600080fd5b810190808051906020019092919050505080336000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055506000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16600073ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a380600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505050610fd8806101536000396000f3fe608060405234801561001057600080fd5b50600436106100cf5760003560e01c806396af3d8a1161008c578063cc549a8d11610066578063cc549a8d14610383578063dd63133a14610410578063e16c7d981461049f578063f2fde38b1461050d576100cf565b806396af3d8a146102365780639e281a98146102b7578063b0619e851461031d576100cf565b80632ce643f2146100d45780632e1a7d4d1461011e5780633319bf1a14610164578063715018a6146101c05780638da5cb5b146101ca5780638f32d59b14610214575b600080fd5b6100dc610551565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b61014a6004803603602081101561013457600080fd5b8101908080359060200190929190505050610577565b604051808215151515815260200191505060405180910390f35b6101a66004803603602081101561017a57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291905050506106c4565b604051808215151515815260200191505060405180910390f35b6101c861076a565b005b6101d261083a565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b61021c610863565b604051808215151515815260200191505060405180910390f35b6102a16004803603608081101561024c57600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff1690602001909291905050506108ba565b6040518082815260200191505060405180910390f35b610303600480360360408110156102cd57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803590602001909291905050506108f9565b604051808215151515815260200191505060405180910390f35b6103696004803603604081101561033357600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610aaa565b604051808215151515815260200191505060405180910390f35b6103ce6004803603606081101561039957600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff169060200190929190505050610b9b565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b610485600480360360a081101561042657600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610bea565b604051808215151515815260200191505060405180910390f35b6104cb600480360360208110156104b557600080fd5b8101908080359060200190929190505050610dd2565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b61054f6004803603602081101561052357600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610e8e565b005b600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b6000610581610863565b61058a57600080fd5b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff169050600160038111156105be57fe5b8173ffffffffffffffffffffffffffffffffffffffff1663b0e315816040518163ffffffff1660e01b815260040160206040518083038186803b15801561060457600080fd5b505afa158015610618573d6000803e3d6000fd5b505050506040513d602081101561062e57600080fd5b8101908080519060200190929190505050600381111561064a57fe5b1461065457600080fd5b823073ffffffffffffffffffffffffffffffffffffffff1631101561067857600080fd5b61068061083a565b73ffffffffffffffffffffffffffffffffffffffff166108fc849081150290604051600060405180830381858888f193505050506106ba57fe5b6001915050919050565b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff161461072057600080fd5b81600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555060019050919050565b610772610863565b61077b57600080fd5b600073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a360008060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905090565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614905090565b60036020528360005260406000206020528260005260406000206020528160005260406000206020528060005260406000206000935093505050505481565b6000610903610863565b61090c57600080fd5b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690506001600381111561094057fe5b8173ffffffffffffffffffffffffffffffffffffffff1663b0e315816040518163ffffffff1660e01b815260040160206040518083038186803b15801561098657600080fd5b505afa15801561099a573d6000803e3d6000fd5b505050506040513d60208110156109b057600080fd5b810190808051906020019092919050505060038111156109cc57fe5b146109d657600080fd5b60008490508073ffffffffffffffffffffffffffffffffffffffff1663a9059cbb33866040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200182815260200192505050602060405180830381600087803b158015610a6257600080fd5b505af1158015610a76573d6000803e3d6000fd5b505050506040513d6020811015610a8c57600080fd5b81019080805190602001909291905050505060019250505092915050565b600080600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663b0619e8585856040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018281526020019250505060206040518083038186803b158015610b5757600080fd5b505afa158015610b6b573d6000803e3d6000fd5b505050506040513d6020811015610b8157600080fd5b810190808051906020019092919050505091505092915050565b6002602052826000526040600020602052816000526040600020602052806000526040600020600092509250509054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b6000610c157f4c616e6400000000000000000000000000000000000000000000000000000000610dd2565b73ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff161480610ca15750610c727f4c616e644c696200000000000000000000000000000000000000000000000000610dd2565b73ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16145b610caa57600080fd5b82600260008861ffff1661ffff16815260200190815260200160002060008761ffff1661ffff16815260200190815260200160002060008660ff1660ff16815260200190815260200160002060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055507f9ddbaf061101ada1338c64912dabc002f73b61a5652827b26a01864e55db68b286868686604051808561ffff1661ffff1681526020018461ffff1661ffff1681526020018360ff1660ff1681526020018273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200194505050505060405180910390a16001905095945050505050565b600080600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98846040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b158015610e4b57600080fd5b505afa158015610e5f573d6000803e3d6000fd5b505050506040513d6020811015610e7557600080fd5b8101908080519060200190929190505050915050919050565b610e96610863565b610e9f57600080fd5b610ea881610eab565b50565b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff161415610ee557600080fd5b8073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a3806000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505056fea265627a7a72315820f2e8ecc318161071539f6e34c57ae51d2d18a6353f1329c6c94b05903bea0f1064736f6c634300050d0032";
        public StandardTileDeploymentBase() : base(BYTECODE) { }
        public StandardTileDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "_galleass", 1)]
        public virtual string Galleass { get; set; }
    }

    public partial class GalleassFunction : GalleassFunctionBase { }

    [Function("galleass", "address")]
    public class GalleassFunctionBase : FunctionMessage
    {

    }

    public partial class GetContractFunction : GetContractFunctionBase { }

    [Function("getContract", "address")]
    public class GetContractFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "_name", 1)]
        public virtual byte[] Name { get; set; }
    }

    public partial class HasPermissionFunction : HasPermissionFunctionBase { }

    [Function("hasPermission", "bool")]
    public class HasPermissionFunctionBase : FunctionMessage
    {
        [Parameter("address", "_contract", 1)]
        public virtual string Contract { get; set; }
        [Parameter("bytes32", "_permission", 2)]
        public virtual byte[] Permission { get; set; }
    }

    public partial class IsOwnerFunction : IsOwnerFunctionBase { }

    [Function("isOwner", "bool")]
    public class IsOwnerFunctionBase : FunctionMessage
    {

    }

    public partial class LandOwnersFunction : LandOwnersFunctionBase { }

    [Function("landOwners", "address")]
    public class LandOwnersFunctionBase : FunctionMessage
    {
        [Parameter("uint16", "", 1)]
        public virtual ushort ReturnValue1 { get; set; }
        [Parameter("uint16", "", 2)]
        public virtual ushort ReturnValue2 { get; set; }
        [Parameter("uint8", "", 3)]
        public virtual byte ReturnValue3 { get; set; }
    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class TokenBalanceFunction : TokenBalanceFunctionBase { }

    [Function("tokenBalance", "uint256")]
    public class TokenBalanceFunctionBase : FunctionMessage
    {
        [Parameter("uint16", "", 1)]
        public virtual ushort ReturnValue1 { get; set; }
        [Parameter("uint16", "", 2)]
        public virtual ushort ReturnValue2 { get; set; }
        [Parameter("uint8", "", 3)]
        public virtual byte ReturnValue3 { get; set; }
        [Parameter("address", "", 4)]
        public virtual string ReturnValue4 { get; set; }
    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class UpgradeGalleassFunction : UpgradeGalleassFunctionBase { }

    [Function("upgradeGalleass", "bool")]
    public class UpgradeGalleassFunctionBase : FunctionMessage
    {
        [Parameter("address", "_galleass", 1)]
        public virtual string Galleass { get; set; }
    }

    public partial class WithdrawFunction : WithdrawFunctionBase { }

    [Function("withdraw", "bool")]
    public class WithdrawFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_amount", 1)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class WithdrawTokenFunction : WithdrawTokenFunctionBase { }

    [Function("withdrawToken", "bool")]
    public class WithdrawTokenFunctionBase : FunctionMessage
    {
        [Parameter("address", "_token", 1)]
        public virtual string Token { get; set; }
        [Parameter("uint256", "_amount", 2)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class OnPurchaseFunction : OnPurchaseFunctionBase { }

    [Function("onPurchase", "bool")]
    public class OnPurchaseFunctionBase : FunctionMessage
    {
        [Parameter("uint16", "_x", 1)]
        public virtual ushort X { get; set; }
        [Parameter("uint16", "_y", 2)]
        public virtual ushort Y { get; set; }
        [Parameter("uint8", "_tile", 3)]
        public virtual byte Tile { get; set; }
        [Parameter("address", "_owner", 4)]
        public virtual string Owner { get; set; }
        [Parameter("uint256", "_amount", 5)]
        public virtual BigInteger Amount { get; set; }
    }

    public partial class LandOwnerEventDTO : LandOwnerEventDTOBase { }

    [Event("LandOwner")]
    public class LandOwnerEventDTOBase : IEventDTO
    {
        [Parameter("uint16", "_x", 1, false )]
        public virtual ushort X { get; set; }
        [Parameter("uint16", "_y", 2, false )]
        public virtual ushort Y { get; set; }
        [Parameter("uint8", "_tile", 3, false )]
        public virtual byte Tile { get; set; }
        [Parameter("address", "_owner", 4, false )]
        public virtual string Owner { get; set; }
    }

    public partial class OwnershipTransferredEventDTO : OwnershipTransferredEventDTOBase { }

    [Event("OwnershipTransferred")]
    public class OwnershipTransferredEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousOwner", 1, true )]
        public virtual string PreviousOwner { get; set; }
        [Parameter("address", "newOwner", 2, true )]
        public virtual string NewOwner { get; set; }
    }

    public partial class GalleassOutputDTO : GalleassOutputDTOBase { }

    [FunctionOutput]
    public class GalleassOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class GetContractOutputDTO : GetContractOutputDTOBase { }

    [FunctionOutput]
    public class GetContractOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class HasPermissionOutputDTO : HasPermissionOutputDTOBase { }

    [FunctionOutput]
    public class HasPermissionOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class IsOwnerOutputDTO : IsOwnerOutputDTOBase { }

    [FunctionOutput]
    public class IsOwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class LandOwnersOutputDTO : LandOwnersOutputDTOBase { }

    [FunctionOutput]
    public class LandOwnersOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class TokenBalanceOutputDTO : TokenBalanceOutputDTOBase { }

    [FunctionOutput]
    public class TokenBalanceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }










}
