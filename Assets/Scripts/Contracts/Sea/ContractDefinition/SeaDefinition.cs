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

namespace Galleass3D.Contracts.Sea.ContractDefinition
{


    public partial class SeaDeployment : SeaDeploymentBase
    {
        public SeaDeployment() : base(BYTECODE) { }
        public SeaDeployment(string byteCode) : base(byteCode) { }
    }

    public class SeaDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x60806040526000600160146101000a81548160ff021916908360ff16021790555034801561002c57600080fd5b506040516115503803806115508339818101604052602081101561004f57600080fd5b810190808051906020019092919050505080336000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055506000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16600073ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a380600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555050506113e18061016f6000396000f3fe608060405234801561001057600080fd5b50600436106100b45760003560e01c80638f32d59b116100715780638f32d59b146103405780639779f924146103625780639e281a98146103f2578063b0619e8514610458578063e16c7d98146104be578063f2fde38b1461052c576100b4565b80632ce643f2146100b95780632e1a7d4d146101035780633319bf1a14610149578063715018a6146101a55780637a1091ea146101af5780638da5cb5b146102f6575b600080fd5b6100c1610570565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b61012f6004803603602081101561011957600080fd5b8101908080359060200190929190505050610596565b604051808215151515815260200191505060405180910390f35b61018b6004803603602081101561015f57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291905050506106e3565b604051808215151515815260200191505060405180910390f35b6101ad610789565b005b6101fb600480360360408110156101c557600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610859565b604051808d81526020018c73ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018b73ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018a151515158152602001891515151581526020018861ffff1661ffff1681526020018761ffff1661ffff1681526020018661ffff1661ffff1681526020018561ffff1661ffff1681526020018461ffff1661ffff1681526020018361ffff1661ffff1681526020018261ffff1661ffff1681526020019c5050505050505050505050505060405180910390f35b6102fe610982565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6103486109ab565b604051808215151515815260200191505060405180910390f35b6103d8600480360360a081101561037857600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190803561ffff169060200190929190803561ffff169060200190929190803561ffff169060200190929190505050610a02565b604051808215151515815260200191505060405180910390f35b61043e6004803603604081101561040857600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610d97565b604051808215151515815260200191505060405180910390f35b6104a46004803603604081101561046e57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610f48565b604051808215151515815260200191505060405180910390f35b6104ea600480360360208110156104d457600080fd5b8101908080359060200190929190505050611039565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b61056e6004803603602081101561054257600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291905050506110f5565b005b600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b60006105a06109ab565b6105a957600080fd5b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff169050600160038111156105dd57fe5b8173ffffffffffffffffffffffffffffffffffffffff1663b0e315816040518163ffffffff1660e01b815260040160206040518083038186803b15801561062357600080fd5b505afa158015610637573d6000803e3d6000fd5b505050506040513d602081101561064d57600080fd5b8101908080519060200190929190505050600381111561066957fe5b1461067357600080fd5b823073ffffffffffffffffffffffffffffffffffffffff1631101561069757600080fd5b61069f610982565b73ffffffffffffffffffffffffffffffffffffffff166108fc849081150290604051600060405180830381858888f193505050506106d957fe5b6001915050919050565b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff161461073f57600080fd5b81600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555060019050919050565b6107916109ab565b61079a57600080fd5b600073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a360008060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550565b6002602052816000526040600020602052806000526040600020600091509150508060000154908060010160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16908060020160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16908060020160149054906101000a900460ff16908060020160159054906101000a900460ff16908060020160169054906101000a900461ffff16908060020160189054906101000a900461ffff169080600201601a9054906101000a900461ffff169080600201601c9054906101000a900461ffff169080600201601e9054906101000a900461ffff16908060030160009054906101000a900461ffff16908060030160029054906101000a900461ffff1690508c565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905090565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614905090565b60007f53656100000000000000000000000000000000000000000000000000000000006000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98836040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b158015610a9d57600080fd5b505afa158015610ab1573d6000803e3d6000fd5b505050506040513d6020811015610ac757600080fd5b810190808051906020019092919050505073ffffffffffffffffffffffffffffffffffffffff163073ffffffffffffffffffffffffffffffffffffffff1614610b0f57600080fd5b600260008973ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020600088815260200190815260200160002060020160149054906101000a900460ff1615610b7a57600080fd5b610ba4337f656d6261726b5368697073000000000000000000000000000000000000000000610f48565b610bad57600080fd5b6000600260008a73ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008981526020019081526020016000209050878160000181905550888160010160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555060018160020160146101000a81548160ff02191690831515021790555060008160020160156101000a81548160ff021916908315150217905550868160020160166101000a81548161ffff021916908361ffff160217905550858160020160186101000a81548161ffff021916908361ffff1602179055508481600201601a6101000a81548161ffff021916908361ffff160217905550600089905060008173ffffffffffffffffffffffffffffffffffffffff16636352211e8b6040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b158015610d3c57600080fd5b505afa158015610d50573d6000803e3d6000fd5b505050506040513d6020811015610d6657600080fd5b81019080805190602001909291905050509050610d858b8b8386611112565b60019550505050505095945050505050565b6000610da16109ab565b610daa57600080fd5b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905060016003811115610dde57fe5b8173ffffffffffffffffffffffffffffffffffffffff1663b0e315816040518163ffffffff1660e01b815260040160206040518083038186803b158015610e2457600080fd5b505afa158015610e38573d6000803e3d6000fd5b505050506040513d6020811015610e4e57600080fd5b81019080805190602001909291905050506003811115610e6a57fe5b14610e7457600080fd5b60008490508073ffffffffffffffffffffffffffffffffffffffff1663a9059cbb33866040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200182815260200192505050602060405180830381600087803b158015610f0057600080fd5b505af1158015610f14573d6000803e3d6000fd5b505050506040513d6020811015610f2a57600080fd5b81019080805190602001909291905050505060019250505092915050565b600080600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663b0619e8585856040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018281526020019250505060206040518083038186803b158015610ff557600080fd5b505afa158015611009573d6000803e3d6000fd5b505050506040513d602081101561101f57600080fd5b810190808051906020019092919050505091505092915050565b600080600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98846040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b1580156110b257600080fd5b505afa1580156110c6573d6000803e3d6000fd5b505050506040513d60208110156110dc57600080fd5b8101908080519060200190929190505050915050919050565b6110fd6109ab565b61110657600080fd5b61110f816112b4565b50565b8060020160189054906101000a900461ffff1661ffff168160020160169054906101000a900461ffff1661ffff168373ffffffffffffffffffffffffffffffffffffffff167f77fac33f8b645a9b9465f6761d518168a950417432328f6d53b19cb20d8f82c84287898760020160149054906101000a900460ff168860020160159054906101000a900460ff1689600201601a9054906101000a900461ffff168a600201601c9054906101000a900461ffff168b600201601e9054906101000a900461ffff168c60030160009054906101000a900461ffff168d60030160029054906101000a900461ffff16604051808b81526020018a81526020018973ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200188151515158152602001871515151581526020018661ffff1661ffff1681526020018561ffff1661ffff1681526020018461ffff1661ffff1681526020018361ffff1661ffff1681526020018261ffff1661ffff1681526020019a505050505050505050505060405180910390a450505050565b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff1614156112ee57600080fd5b8073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a3806000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505056fea265627a7a72315820687a98c56fcf4bb22796d60c11b5724b5a1f6094f571116a69a1d14f8eb572ee64736f6c634300050d0032";
        public SeaDeploymentBase() : base(BYTECODE) { }
        public SeaDeploymentBase(string byteCode) : base(byteCode) { }
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

    public partial class ShipsFunction : ShipsFunctionBase { }

    [Function("ships", typeof(ShipsOutputDTO))]
    public class ShipsFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("uint256", "", 2)]
        public virtual BigInteger ReturnValue2 { get; set; }
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

    public partial class EmbarkFunction : EmbarkFunctionBase { }

    [Function("embark", "bool")]
    public class EmbarkFunctionBase : FunctionMessage
    {
        [Parameter("address", "_contract", 1)]
        public virtual string Contract { get; set; }
        [Parameter("uint256", "_shipId", 2)]
        public virtual BigInteger ShipId { get; set; }
        [Parameter("uint16", "_x", 3)]
        public virtual ushort X { get; set; }
        [Parameter("uint16", "_y", 4)]
        public virtual ushort Y { get; set; }
        [Parameter("uint16", "_location", 5)]
        public virtual ushort Location { get; set; }
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

    public partial class ShipUpdateEventDTO : ShipUpdateEventDTOBase { }

    [Event("ShipUpdate")]
    public class ShipUpdateEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "timestamp", 1, false )]
        public virtual BigInteger Timestamp { get; set; }
        [Parameter("uint256", "id", 2, false )]
        public virtual BigInteger Id { get; set; }
        [Parameter("address", "contractAddress", 3, false )]
        public virtual string ContractAddress { get; set; }
        [Parameter("address", "owner", 4, true )]
        public virtual string Owner { get; set; }
        [Parameter("bool", "floating", 5, false )]
        public virtual bool Floating { get; set; }
        [Parameter("bool", "sailing", 6, false )]
        public virtual bool Sailing { get; set; }
        [Parameter("uint16", "x", 7, true )]
        public virtual ushort X { get; set; }
        [Parameter("uint16", "y", 8, true )]
        public virtual ushort Y { get; set; }
        [Parameter("uint16", "location", 9, false )]
        public virtual ushort Location { get; set; }
        [Parameter("uint16", "destX", 10, false )]
        public virtual ushort DestX { get; set; }
        [Parameter("uint16", "destY", 11, false )]
        public virtual ushort DestY { get; set; }
        [Parameter("uint16", "destLocation", 12, false )]
        public virtual ushort DestLocation { get; set; }
        [Parameter("uint16", "destBlock", 13, false )]
        public virtual ushort DestBlock { get; set; }
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

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class ShipsOutputDTO : ShipsOutputDTOBase { }

    [FunctionOutput]
    public class ShipsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "id", 1)]
        public virtual BigInteger Id { get; set; }
        [Parameter("address", "contractAddress", 2)]
        public virtual string ContractAddress { get; set; }
        [Parameter("address", "owner", 3)]
        public virtual string Owner { get; set; }
        [Parameter("bool", "floating", 4)]
        public virtual bool Floating { get; set; }
        [Parameter("bool", "sailing", 5)]
        public virtual bool Sailing { get; set; }
        [Parameter("uint16", "x", 6)]
        public virtual ushort X { get; set; }
        [Parameter("uint16", "y", 7)]
        public virtual ushort Y { get; set; }
        [Parameter("uint16", "location", 8)]
        public virtual ushort Location { get; set; }
        [Parameter("uint16", "destX", 9)]
        public virtual ushort DestX { get; set; }
        [Parameter("uint16", "destY", 10)]
        public virtual ushort DestY { get; set; }
        [Parameter("uint16", "destLocation", 11)]
        public virtual ushort DestLocation { get; set; }
        [Parameter("uint16", "destBlock", 12)]
        public virtual ushort DestBlock { get; set; }
    }










}
