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

namespace Galleass3D.Contracts.Predecessor.ContractDefinition
{


    public partial class PredecessorDeployment : PredecessorDeploymentBase
    {
        public PredecessorDeployment() : base(BYTECODE) { }
        public PredecessorDeployment(string byteCode) : base(byteCode) { }
    }

    public class PredecessorDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50336000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055506000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16600073ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a36001600060146101000a81548160ff021916908360038111156100ec57fe5b0217905550610845806101006000396000f3fe608060405234801561001057600080fd5b50600436106100b45760003560e01c80638f32d59b116100715780638f32d59b14610195578063b0e31581146101b7578063c040e6b8146101e3578063cc26839314610205578063da56eedb14610249578063f2fde38b14610293576100b4565b806305e88b69146100b95780632b68b9c6146100db578063715018a6146100fd5780638456cb59146101075780638da5cb5b146101295780638e1a55fc14610173575b600080fd5b6100c16102d7565b604051808215151515815260200191505060405180910390f35b6100e3610343565b604051808215151515815260200191505060405180910390f35b6101056103a8565b005b61010f610478565b604051808215151515815260200191505060405180910390f35b6101316104e3565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b61017b61050c565b604051808215151515815260200191505060405180910390f35b61019d610578565b604051808215151515815260200191505060405180910390f35b6101bf6105cf565b604051808260038111156101cf57fe5b60ff16815260200191505060405180910390f35b6101eb6105e2565b604051808215151515815260200191505060405180910390f35b6102476004803603602081101561021b57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919050505061064e565b005b6102516106d5565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6102d5600480360360208110156102a957600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291905050506106fb565b005b6000600260038111156102e657fe5b600060149054906101000a900460ff16600381111561030157fe5b1461030b57600080fd5b610313610578565b61031c57600080fd5b6003600060146101000a81548160ff0219169083600381111561033b57fe5b021790555090565b600060038081111561035157fe5b600060149054906101000a900460ff16600381111561036c57fe5b141561037757600080fd5b61037f610578565b61038857600080fd5b6103906104e3565b73ffffffffffffffffffffffffffffffffffffffff16ff5b6103b0610578565b6103b957600080fd5b600073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a360008060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550565b600060038081111561048657fe5b600060149054906101000a900460ff1660038111156104a157fe5b14156104ac57600080fd5b6104b4610578565b6104bd57600080fd5b60008060146101000a81548160ff021916908360038111156104db57fe5b021790555090565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905090565b600060038081111561051a57fe5b600060149054906101000a900460ff16600381111561053557fe5b141561054057600080fd5b610548610578565b61055157600080fd5b6001600060146101000a81548160ff0219169083600381111561057057fe5b021790555090565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614905090565b600060149054906101000a900460ff1681565b60006003808111156105f057fe5b600060149054906101000a900460ff16600381111561060b57fe5b141561061657600080fd5b61061e610578565b61062757600080fd5b6002600060146101000a81548160ff0219169083600381111561064657fe5b021790555090565b610656610578565b61065f57600080fd5b60038081111561066b57fe5b600060149054906101000a900460ff16600381111561068657fe5b141561069157600080fd5b80600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555050565b600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b610703610578565b61070c57600080fd5b61071581610718565b50565b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff16141561075257600080fd5b8073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a3806000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505056fea265627a7a72315820a337fc7264341850ce8a04246f4a2d320ae2dfb0248e18b080e9a5458b04647c64736f6c634300050d0032";
        public PredecessorDeploymentBase() : base(BYTECODE) { }
        public PredecessorDeploymentBase(string byteCode) : base(byteCode) { }

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

    public partial class SetDescendantFunction : SetDescendantFunctionBase { }

    [Function("setDescendant")]
    public class SetDescendantFunctionBase : FunctionMessage
    {
        [Parameter("address", "_descendant", 1)]
        public virtual string Descendant { get; set; }
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
