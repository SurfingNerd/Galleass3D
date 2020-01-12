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

namespace Galleass3D.Contracts.Galleass.ContractDefinition
{


    public partial class GalleassDeployment : GalleassDeploymentBase
    {
        public GalleassDeployment() : base(BYTECODE) { }
        public GalleassDeployment(string byteCode) : base(byteCode) { }
    }

    public class GalleassDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50336000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055506000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16600073ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a36001600060146101000a81548160ff021916908360038111156100ec57fe5b02179055506116d0806101006000396000f3fe60806040526004361061012a5760003560e01c80638f32d59b116100ab578063c040e6b81161006f578063c040e6b8146105ff578063cc2683931461062e578063da56eedb1461067f578063e16c7d98146106d6578063eb2c022314610751578063f2fde38b146107ba5761012a565b80638f32d59b146104215780639e281a9814610450578063a6c3e6b9146104c3578063b0619e8514610553578063b0e31581146105c65761012a565b8063715018a6116100f2578063715018a6146102e25780637ed77c9c146102f95780638456cb591461036c5780638da5cb5b1461039b5780638e1a55fc146103f25761012a565b806305e88b691461012f57806306fdde031461015e5780632b68b9c6146101ee5780632e1a7d4d1461021d5780633b424f0914610263575b600080fd5b34801561013b57600080fd5b5061014461080b565b604051808215151515815260200191505060405180910390f35b34801561016a57600080fd5b50610173610877565b6040518080602001828103825283818151815260200191508051906020019080838360005b838110156101b3578082015181840152602081019050610198565b50505050905090810190601f1680156101e05780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b3480156101fa57600080fd5b506102036108b0565b604051808215151515815260200191505060405180910390f35b6102496004803603602081101561023357600080fd5b8101908080359060200190929190505050610915565b604051808215151515815260200191505060405180910390f35b34801561026f57600080fd5b506102c86004803603606081101561028657600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190803515159060200190929190505050610997565b604051808215151515815260200191505060405180910390f35b3480156102ee57600080fd5b506102f7610ac6565b005b34801561030557600080fd5b506103526004803603604081101561031c57600080fd5b8101908080359060200190929190803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610b96565b604051808215151515815260200191505060405180910390f35b34801561037857600080fd5b50610381610cd6565b604051808215151515815260200191505060405180910390f35b3480156103a757600080fd5b506103b0610d41565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b3480156103fe57600080fd5b50610407610d6a565b604051808215151515815260200191505060405180910390f35b34801561042d57600080fd5b50610436610dd6565b604051808215151515815260200191505060405180910390f35b34801561045c57600080fd5b506104a96004803603604081101561047357600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610e2d565b604051808215151515815260200191505060405180910390f35b3480156104cf57600080fd5b506104d8610f13565b6040518080602001828103825283818151815260200191508051906020019080838360005b838110156105185780820151818401526020810190506104fd565b50505050905090810190601f1680156105455780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b34801561055f57600080fd5b506105ac6004803603604081101561057657600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610f2f565b604051808215151515815260200191505060405180910390f35b3480156105d257600080fd5b506105db6110d6565b604051808260038111156105eb57fe5b60ff16815260200191505060405180910390f35b34801561060b57600080fd5b506106146110e9565b604051808215151515815260200191505060405180910390f35b34801561063a57600080fd5b5061067d6004803603602081101561065157600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050611155565b005b34801561068b57600080fd5b506106946111dc565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b3480156106e257600080fd5b5061070f600480360360208110156106f957600080fd5b8101908080359060200190929190505050611202565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b34801561075d57600080fd5b506107a06004803603602081101561077457600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919050505061134a565b604051808215151515815260200191505060405180910390f35b3480156107c657600080fd5b50610809600480360360208110156107dd57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050611562565b005b60006002600381111561081a57fe5b600060149054906101000a900460ff16600381111561083557fe5b1461083f57600080fd5b610847610dd6565b61085057600080fd5b6003600060146101000a81548160ff0219169083600381111561086f57fe5b021790555090565b6040518060400160405280600881526020017f47616c6c6561737300000000000000000000000000000000000000000000000081525081565b60006003808111156108be57fe5b600060149054906101000a900460ff1660038111156108d957fe5b14156108e457600080fd5b6108ec610dd6565b6108f557600080fd5b6108fd610d41565b73ffffffffffffffffffffffffffffffffffffffff16ff5b600061091f610dd6565b61092857600080fd5b813073ffffffffffffffffffffffffffffffffffffffff1631101561094c57600080fd5b610954610d41565b73ffffffffffffffffffffffffffffffffffffffff166108fc839081150290604051600060405180830381858888f1935050505061098e57fe5b60019050919050565b60006109a1610dd6565b6109aa57600080fd5b600160038111156109b757fe5b600060149054906101000a900460ff1660038111156109d257fe5b146109dc57600080fd5b81600360008673ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020600085815260200190815260200160002060006101000a81548160ff0219169083151502179055507fb842c2420390626d77bc21fcee7919720b98a4e11cdc34c7982633a598ba8265848484604051808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200183815260200182151515158152602001935050505060405180910390a1600190509392505050565b610ace610dd6565b610ad757600080fd5b600073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a360008060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550565b6000610ba0610dd6565b610ba957600080fd5b60016003811115610bb657fe5b600060149054906101000a900460ff166003811115610bd157fe5b14610bdb57600080fd5b816002600085815260200190815260200160002060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055507fb37bbf7809b7e317092a2eb447b6a453fcd8a75921c9b754ec29dffd40728242838333604051808481526020018373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001935050505060405180910390a16001905092915050565b6000600380811115610ce457fe5b600060149054906101000a900460ff166003811115610cff57fe5b1415610d0a57600080fd5b610d12610dd6565b610d1b57600080fd5b60008060146101000a81548160ff02191690836003811115610d3957fe5b021790555090565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905090565b6000600380811115610d7857fe5b600060149054906101000a900460ff166003811115610d9357fe5b1415610d9e57600080fd5b610da6610dd6565b610daf57600080fd5b6001600060146101000a81548160ff02191690836003811115610dce57fe5b021790555090565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614905090565b6000610e37610dd6565b610e4057600080fd5b60008390508073ffffffffffffffffffffffffffffffffffffffff1663a9059cbb33856040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200182815260200192505050602060405180830381600087803b158015610ecc57600080fd5b505af1158015610ee0573d6000803e3d6000fd5b505050506040513d6020811015610ef657600080fd5b810190808051906020019092919050505050600191505092915050565b6040518060600160405280602481526020016116786024913981565b60008073ffffffffffffffffffffffffffffffffffffffff16600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff161461106f57600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1663b0619e8584846040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018281526020019250505060206040518083038186803b15801561102d57600080fd5b505afa158015611041573d6000803e3d6000fd5b505050506040513d602081101561105757600080fd5b810190808051906020019092919050505090506110d0565b600360008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020600083815260200190815260200160002060009054906101000a900460ff1690505b92915050565b600060149054906101000a900460ff1681565b60006003808111156110f757fe5b600060149054906101000a900460ff16600381111561111257fe5b141561111d57600080fd5b611125610dd6565b61112e57600080fd5b6002600060146101000a81548160ff0219169083600381111561114d57fe5b021790555090565b61115d610dd6565b61116657600080fd5b60038081111561117257fe5b600060149054906101000a900460ff16600381111561118d57fe5b141561119857600080fd5b80600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555050565b600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b60008073ffffffffffffffffffffffffffffffffffffffff16600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff161461130e57600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1663e16c7d98836040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b1580156112cc57600080fd5b505afa1580156112e0573d6000803e3d6000fd5b505050506040513d60208110156112f657600080fd5b81019080805190602001909291905050509050611345565b6002600083815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690505b919050565b6000611354610dd6565b61135d57600080fd5b6001600381111561136a57fe5b600060149054906101000a900460ff16600381111561138557fe5b1461138f57600080fd5b8173ffffffffffffffffffffffffffffffffffffffff16633319bf1a600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff166040518263ffffffff1660e01b8152600401808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001915050602060405180830381600087803b15801561143057600080fd5b505af1158015611444573d6000803e3d6000fd5b505050506040513d602081101561145a57600080fd5b8101908080519060200190929190505050507f7b563a648f580bb883395153219ac9f16d4acd407bd8bf47e4486fd9f58b840d82600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1633604051808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001935050505060405180910390a160019050919050565b61156a610dd6565b61157357600080fd5b61157c8161157f565b50565b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff1614156115b957600080fd5b8073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a3806000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505056fe54686f6d61732048616c6c65722074686f6d61732e68616c6c6572406c616231302e696fa265627a7a72315820b81a95d0fc4cefe748c909628feab02b1a7cc58cbf220ef71cf82b70b5f5dee264736f6c634300050d0032";
        public GalleassDeploymentBase() : base(BYTECODE) { }
        public GalleassDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class AuthorFunction : AuthorFunctionBase { }

    [Function("author", "string")]
    public class AuthorFunctionBase : FunctionMessage
    {

    }

    public partial class BuildFunction : BuildFunctionBase { }

    [Function("build", "bool")]
    public class BuildFunctionBase : FunctionMessage
    {

    }

    public partial class DescendantFunction : DescendantFunctionBase { }

    [Function("descendant", "address")]
    public class DescendantFunctionBase : FunctionMessage
    {

    }

    public partial class DestructFunction : DestructFunctionBase { }

    [Function("destruct", "bool")]
    public class DestructFunctionBase : FunctionMessage
    {

    }

    public partial class IsOwnerFunction : IsOwnerFunctionBase { }

    [Function("isOwner", "bool")]
    public class IsOwnerFunctionBase : FunctionMessage
    {

    }

    public partial class NameFunction : NameFunctionBase { }

    [Function("name", "string")]
    public class NameFunctionBase : FunctionMessage
    {

    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class PauseFunction : PauseFunctionBase { }

    [Function("pause", "bool")]
    public class PauseFunctionBase : FunctionMessage
    {

    }

    public partial class ProductionFunction : ProductionFunctionBase { }

    [Function("production", "bool")]
    public class ProductionFunctionBase : FunctionMessage
    {

    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class SetDescendantFunction : SetDescendantFunctionBase { }

    [Function("setDescendant")]
    public class SetDescendantFunctionBase : FunctionMessage
    {
        [Parameter("address", "_descendant", 1)]
        public virtual string Descendant { get; set; }
    }

    public partial class StageFunction : StageFunctionBase { }

    [Function("stage", "bool")]
    public class StageFunctionBase : FunctionMessage
    {

    }

    public partial class StagedModeFunction : StagedModeFunctionBase { }

    [Function("stagedMode", "uint8")]
    public class StagedModeFunctionBase : FunctionMessage
    {

    }

    public partial class TransferOwnershipFunction : TransferOwnershipFunctionBase { }

    [Function("transferOwnership")]
    public class TransferOwnershipFunctionBase : FunctionMessage
    {
        [Parameter("address", "newOwner", 1)]
        public virtual string NewOwner { get; set; }
    }

    public partial class UpgradeContractFunction : UpgradeContractFunctionBase { }

    [Function("upgradeContract", "bool")]
    public class UpgradeContractFunctionBase : FunctionMessage
    {
        [Parameter("address", "_contract", 1)]
        public virtual string Contract { get; set; }
    }

    public partial class SetContractFunction : SetContractFunctionBase { }

    [Function("setContract", "bool")]
    public class SetContractFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "_name", 1)]
        public virtual byte[] Name { get; set; }
        [Parameter("address", "_contract", 2)]
        public virtual string Contract { get; set; }
    }

    public partial class SetPermissionFunction : SetPermissionFunctionBase { }

    [Function("setPermission", "bool")]
    public class SetPermissionFunctionBase : FunctionMessage
    {
        [Parameter("address", "_contract", 1)]
        public virtual string Contract { get; set; }
        [Parameter("bytes32", "_permission", 2)]
        public virtual byte[] Permission { get; set; }
        [Parameter("bool", "_value", 3)]
        public virtual bool Value { get; set; }
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

    public partial class OwnershipTransferredEventDTO : OwnershipTransferredEventDTOBase { }

    [Event("OwnershipTransferred")]
    public class OwnershipTransferredEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousOwner", 1, true )]
        public virtual string PreviousOwner { get; set; }
        [Parameter("address", "newOwner", 2, true )]
        public virtual string NewOwner { get; set; }
    }

    public partial class SetContractEventDTO : SetContractEventDTOBase { }

    [Event("SetContract")]
    public class SetContractEventDTOBase : IEventDTO
    {
        [Parameter("bytes32", "_name", 1, false )]
        public virtual byte[] Name { get; set; }
        [Parameter("address", "_contractAddress", 2, false )]
        public virtual string ContractAddress { get; set; }
        [Parameter("address", "_whoDid", 3, false )]
        public virtual string WhoDid { get; set; }
    }

    public partial class SetPermissionEventDTO : SetPermissionEventDTOBase { }

    [Event("SetPermission")]
    public class SetPermissionEventDTOBase : IEventDTO
    {
        [Parameter("address", "_account", 1, false )]
        public virtual string Account { get; set; }
        [Parameter("bytes32", "_permission", 2, false )]
        public virtual byte[] Permission { get; set; }
        [Parameter("bool", "_value", 3, false )]
        public virtual bool Value { get; set; }
    }

    public partial class UpgradeContractEventDTO : UpgradeContractEventDTOBase { }

    [Event("UpgradeContract")]
    public class UpgradeContractEventDTOBase : IEventDTO
    {
        [Parameter("address", "_contractAddress", 1, false )]
        public virtual string ContractAddress { get; set; }
        [Parameter("address", "_descendant", 2, false )]
        public virtual string Descendant { get; set; }
        [Parameter("address", "_whoDid", 3, false )]
        public virtual string WhoDid { get; set; }
    }

    public partial class AuthorOutputDTO : AuthorOutputDTOBase { }

    [FunctionOutput]
    public class AuthorOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class DescendantOutputDTO : DescendantOutputDTOBase { }

    [FunctionOutput]
    public class DescendantOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class IsOwnerOutputDTO : IsOwnerOutputDTOBase { }

    [FunctionOutput]
    public class IsOwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }

    public partial class NameOutputDTO : NameOutputDTOBase { }

    [FunctionOutput]
    public class NameOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }











    public partial class StagedModeOutputDTO : StagedModeOutputDTOBase { }

    [FunctionOutput]
    public class StagedModeOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint8", "", 1)]
        public virtual byte ReturnValue1 { get; set; }
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




}
