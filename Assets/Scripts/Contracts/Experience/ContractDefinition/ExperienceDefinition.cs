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

namespace Galleass3D.Contracts.Experience.ContractDefinition
{


    public partial class ExperienceDeployment : ExperienceDeploymentBase
    {
        public ExperienceDeployment() : base(BYTECODE) { }
        public ExperienceDeployment(string byteCode) : base(byteCode) { }
    }

    public class ExperienceDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b506040516111163803806111168339818101604052602081101561003357600080fd5b810190808051906020019092919050505080336000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055506000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16600073ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a380600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505050610fc3806101536000396000f3fe608060405234801561001057600080fd5b50600436106100b45760003560e01c80638f32d59b116100715780638f32d59b1461026f5780639e281a9814610291578063a8270f40146102f7578063b0619e8514610361578063e16c7d98146103c7578063f2fde38b14610435576100b4565b80632ce643f2146100b95780632d578304146101035780632e1a7d4d146101795780633319bf1a146101bf578063715018a61461021b5780638da5cb5b14610225575b600080fd5b6100c1610479565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b61015f6004803603606081101561011957600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803561ffff16906020019092919080351515906020019092919050505061049f565b604051808215151515815260200191505060405180910390f35b6101a56004803603602081101561018f57600080fd5b81019080803590602001909291905050506107a9565b604051808215151515815260200191505060405180910390f35b610201600480360360208110156101d557600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291905050506108f6565b604051808215151515815260200191505060405180910390f35b61022361099c565b005b61022d610a6c565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b610277610a95565b604051808215151515815260200191505060405180910390f35b6102dd600480360360408110156102a757600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610aec565b604051808215151515815260200191505060405180910390f35b6103476004803603604081101561030d57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803561ffff169060200190929190505050610c9d565b604051808215151515815260200191505060405180910390f35b6103ad6004803603604081101561037757600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610ccc565b604051808215151515815260200191505060405180910390f35b6103f3600480360360208110156103dd57600080fd5b8101908080359060200190929190505050610dbd565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6104776004803603602081101561044b57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610e79565b005b600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b60007f457870657269656e6365000000000000000000000000000000000000000000006000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98836040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b15801561053a57600080fd5b505afa15801561054e573d6000803e3d6000fd5b505050506040513d602081101561056457600080fd5b810190808051906020019092919050505073ffffffffffffffffffffffffffffffffffffffff163073ffffffffffffffffffffffffffffffffffffffff16146105ac57600080fd5b6105d6337f757064617465457870657269656e636500000000000000000000000000000000610ccc565b610648576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260198152602001807f726571756972657320757064617465457870657269656e63650000000000000081525060200191505060405180910390fd5b83600260008873ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008761ffff1661ffff16815260200190815260200160002060006101000a81548160ff0219169083151502179055507f6e9ffc8a714605d41715b0213f08fda9f8f002b33fa4834c2c56a680d1d1c94d8686600260008a73ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008961ffff1661ffff16815260200190815260200160002060009054906101000a900460ff16604051808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018361ffff1661ffff16815260200182151515158152602001935050505060405180910390a16001925050509392505050565b60006107b3610a95565b6107bc57600080fd5b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff169050600160038111156107f057fe5b8173ffffffffffffffffffffffffffffffffffffffff1663b0e315816040518163ffffffff1660e01b815260040160206040518083038186803b15801561083657600080fd5b505afa15801561084a573d6000803e3d6000fd5b505050506040513d602081101561086057600080fd5b8101908080519060200190929190505050600381111561087c57fe5b1461088657600080fd5b823073ffffffffffffffffffffffffffffffffffffffff163110156108aa57600080fd5b6108b2610a6c565b73ffffffffffffffffffffffffffffffffffffffff166108fc849081150290604051600060405180830381858888f193505050506108ec57fe5b6001915050919050565b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff161461095257600080fd5b81600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555060019050919050565b6109a4610a95565b6109ad57600080fd5b600073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a360008060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905090565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614905090565b6000610af6610a95565b610aff57600080fd5b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905060016003811115610b3357fe5b8173ffffffffffffffffffffffffffffffffffffffff1663b0e315816040518163ffffffff1660e01b815260040160206040518083038186803b158015610b7957600080fd5b505afa158015610b8d573d6000803e3d6000fd5b505050506040513d6020811015610ba357600080fd5b81019080805190602001909291905050506003811115610bbf57fe5b14610bc957600080fd5b60008490508073ffffffffffffffffffffffffffffffffffffffff1663a9059cbb33866040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200182815260200192505050602060405180830381600087803b158015610c5557600080fd5b505af1158015610c69573d6000803e3d6000fd5b505050506040513d6020811015610c7f57600080fd5b81019080805190602001909291905050505060019250505092915050565b60026020528160005260406000206020528060005260406000206000915091509054906101000a900460ff1681565b600080600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663b0619e8585856040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018281526020019250505060206040518083038186803b158015610d7957600080fd5b505afa158015610d8d573d6000803e3d6000fd5b505050506040513d6020811015610da357600080fd5b810190808051906020019092919050505091505092915050565b600080600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98846040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b158015610e3657600080fd5b505afa158015610e4a573d6000803e3d6000fd5b505050506040513d6020811015610e6057600080fd5b8101908080519060200190929190505050915050919050565b610e81610a95565b610e8a57600080fd5b610e9381610e96565b50565b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff161415610ed057600080fd5b8073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a3806000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505056fea265627a7a723158206a77b0956b12c08e5d22a1d846499068f3b5453092663c326c7e5f21971b777364736f6c634300050d0032";
        public ExperienceDeploymentBase() : base(BYTECODE) { }
        public ExperienceDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "_galleass", 1)]
        public virtual string Galleass { get; set; }
    }

    public partial class ExperienceFunction : ExperienceFunctionBase { }

    [Function("experience", "bool")]
    public class ExperienceFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("uint16", "", 2)]
        public virtual ushort ReturnValue2 { get; set; }
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

    public partial class UpdateFunction : UpdateFunctionBase { }

    [Function("update", "bool")]
    public class UpdateFunctionBase : FunctionMessage
    {
        [Parameter("address", "_player", 1)]
        public virtual string Player { get; set; }
        [Parameter("uint16", "_milestone", 2)]
        public virtual ushort Milestone { get; set; }
        [Parameter("bool", "_value", 3)]
        public virtual bool Value { get; set; }
    }

    public partial class ExperienceUpdateEventDTO : ExperienceUpdateEventDTOBase { }

    [Event("ExperienceUpdate")]
    public class ExperienceUpdateEventDTOBase : IEventDTO
    {
        [Parameter("address", "_owner", 1, false )]
        public virtual string Owner { get; set; }
        [Parameter("uint16", "_milestone", 2, false )]
        public virtual ushort Milestone { get; set; }
        [Parameter("bool", "_value", 3, false )]
        public virtual bool Value { get; set; }
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

    public partial class ExperienceOutputDTO : ExperienceOutputDTOBase { }

    [FunctionOutput]
    public class ExperienceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
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












}
