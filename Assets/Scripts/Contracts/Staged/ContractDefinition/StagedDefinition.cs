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

namespace Galleass3D.Contracts.Staged.ContractDefinition
{


    public partial class StagedDeployment : StagedDeploymentBase
    {
        public StagedDeployment() : base(BYTECODE) { }
        public StagedDeployment(string byteCode) : base(byteCode) { }
    }

    public class StagedDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50336000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055506000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16600073ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a36001600060146101000a81548160ff021916908360038111156100ec57fe5b02179055506106f4806101006000396000f3fe608060405234801561001057600080fd5b506004361061009e5760003560e01c80638e1a55fc116100665780638e1a55fc1461015d5780638f32d59b1461017f578063b0e31581146101a1578063c040e6b8146101cd578063f2fde38b146101ef5761009e565b806305e88b69146100a35780632b68b9c6146100c5578063715018a6146100e75780638456cb59146100f15780638da5cb5b14610113575b600080fd5b6100ab610233565b604051808215151515815260200191505060405180910390f35b6100cd61029f565b604051808215151515815260200191505060405180910390f35b6100ef610304565b005b6100f96103d4565b604051808215151515815260200191505060405180910390f35b61011b61043f565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b610165610468565b604051808215151515815260200191505060405180910390f35b6101876104d4565b604051808215151515815260200191505060405180910390f35b6101a961052b565b604051808260038111156101b957fe5b60ff16815260200191505060405180910390f35b6101d561053e565b604051808215151515815260200191505060405180910390f35b6102316004803603602081101561020557600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291905050506105aa565b005b60006002600381111561024257fe5b600060149054906101000a900460ff16600381111561025d57fe5b1461026757600080fd5b61026f6104d4565b61027857600080fd5b6003600060146101000a81548160ff0219169083600381111561029757fe5b021790555090565b60006003808111156102ad57fe5b600060149054906101000a900460ff1660038111156102c857fe5b14156102d357600080fd5b6102db6104d4565b6102e457600080fd5b6102ec61043f565b73ffffffffffffffffffffffffffffffffffffffff16ff5b61030c6104d4565b61031557600080fd5b600073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a360008060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550565b60006003808111156103e257fe5b600060149054906101000a900460ff1660038111156103fd57fe5b141561040857600080fd5b6104106104d4565b61041957600080fd5b60008060146101000a81548160ff0219169083600381111561043757fe5b021790555090565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905090565b600060038081111561047657fe5b600060149054906101000a900460ff16600381111561049157fe5b141561049c57600080fd5b6104a46104d4565b6104ad57600080fd5b6001600060146101000a81548160ff021916908360038111156104cc57fe5b021790555090565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614905090565b600060149054906101000a900460ff1681565b600060038081111561054c57fe5b600060149054906101000a900460ff16600381111561056757fe5b141561057257600080fd5b61057a6104d4565b61058357600080fd5b6002600060146101000a81548160ff021916908360038111156105a257fe5b021790555090565b6105b26104d4565b6105bb57600080fd5b6105c4816105c7565b50565b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff16141561060157600080fd5b8073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a3806000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505056fea265627a7a723158204939886046f70f5ce61f1c41ec660ba0bf0187d6a0ba1a234fa2e4a3efae9f7a64736f6c634300050d0032";
        public StagedDeploymentBase() : base(BYTECODE) { }
        public StagedDeploymentBase(string byteCode) : base(byteCode) { }

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

    public partial class PauseFunction : PauseFunctionBase { }

    [Function("pause", "bool")]
    public class PauseFunctionBase : FunctionMessage
    {

    }

    public partial class StageFunction : StageFunctionBase { }

    [Function("stage", "bool")]
    public class StageFunctionBase : FunctionMessage
    {

    }

    public partial class BuildFunction : BuildFunctionBase { }

    [Function("build", "bool")]
    public class BuildFunctionBase : FunctionMessage
    {

    }

    public partial class DestructFunction : DestructFunctionBase { }

    [Function("destruct", "bool")]
    public class DestructFunctionBase : FunctionMessage
    {

    }

    public partial class ProductionFunction : ProductionFunctionBase { }

    [Function("production", "bool")]
    public class ProductionFunctionBase : FunctionMessage
    {

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



    public partial class StagedModeOutputDTO : StagedModeOutputDTOBase { }

    [FunctionOutput]
    public class StagedModeOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint8", "", 1)]
        public virtual byte ReturnValue1 { get; set; }
    }












}
