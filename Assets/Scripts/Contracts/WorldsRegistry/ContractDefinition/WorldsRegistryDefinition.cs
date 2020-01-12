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

namespace Galleass3D.Contracts.WorldsRegistry.ContractDefinition
{


    public partial class WorldsRegistryDeployment : WorldsRegistryDeploymentBase
    {
        public WorldsRegistryDeployment() : base(BYTECODE) { }
        public WorldsRegistryDeployment(string byteCode) : base(byteCode) { }
    }

    public class WorldsRegistryDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x6080604052336000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055506000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16600073ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a36106f4806100cf6000396000f3fe608060405234801561001057600080fd5b50600436106100885760003560e01c80638da5cb5b1161005b5780638da5cb5b1461016d5780638f32d59b146101b7578063af957661146101d9578063f2fde38b1461025f57610088565b806308dcb3871461008d578063274ad472146100ab578063715018a6146101195780637dacfe6514610123575b600080fd5b6100956102a3565b6040518082815260200191505060405180910390f35b6100d7600480360360208110156100c157600080fd5b81019080803590602001909291905050506102a9565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6101216102dc565b005b61012b6103ac565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6101756103d2565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6101bf6103fb565b604051808215151515815260200191505060405180910390f35b610245600480360360608110156101ef57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610452565b604051808215151515815260200191505060405180910390f35b6102a16004803603602081101561027557600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291905050506105aa565b005b60025481565b60016020528060005260406000206000915054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b6102e46103fb565b6102ed57600080fd5b600073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a360008060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550565b600360009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905090565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614905090565b600061045c6103fb565b61046557600080fd5b8160028190555083600360006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550836001600084815260200190815260200160002060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550817f35934566dce01a64a8e994804d3c00b967edc2b48e194901011fd1692d2ba63b858542604051808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001828152602001935050505060405180910390a2600190509392505050565b6105b26103fb565b6105bb57600080fd5b6105c4816105c7565b50565b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff16141561060157600080fd5b8073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a3806000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505056fea265627a7a72315820366feb22da868880c51869e361d54f5275cd1ceb1c69ed753126261e45235dc264736f6c634300050d0032";
        public WorldsRegistryDeploymentBase() : base(BYTECODE) { }
        public WorldsRegistryDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class IsOwnerFunction : IsOwnerFunctionBase { }

    [Function("isOwner", "bool")]
    public class IsOwnerFunctionBase : FunctionMessage
    {

    }

    public partial class LastCreatedWorldNameFunction : LastCreatedWorldNameFunctionBase { }

    [Function("lastCreatedWorldName", "bytes32")]
    public class LastCreatedWorldNameFunctionBase : FunctionMessage
    {

    }

    public partial class LastCreatedWorldsAddressFunction : LastCreatedWorldsAddressFunctionBase { }

    [Function("lastCreatedWorldsAddress", "address")]
    public class LastCreatedWorldsAddressFunctionBase : FunctionMessage
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

    public partial class WorldsFunction : WorldsFunctionBase { }

    [Function("worlds", "address")]
    public class WorldsFunctionBase : FunctionMessage
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class RegisterGalleasWorldFunction : RegisterGalleasWorldFunctionBase { }

    [Function("registerGalleasWorld", "bool")]
    public class RegisterGalleasWorldFunctionBase : FunctionMessage
    {
        [Parameter("address", "galleasContract", 1)]
        public virtual string GalleasContract { get; set; }
        [Parameter("address", "initiator", 2)]
        public virtual string Initiator { get; set; }
        [Parameter("bytes32", "name", 3)]
        public virtual byte[] Name { get; set; }
    }

    public partial class GalleasWorldRegisteredEventDTO : GalleasWorldRegisteredEventDTOBase { }

    [Event("GalleasWorldRegistered")]
    public class GalleasWorldRegisteredEventDTOBase : IEventDTO
    {
        [Parameter("address", "galeassContract", 1, false )]
        public virtual string GaleassContract { get; set; }
        [Parameter("address", "initiator", 2, false )]
        public virtual string Initiator { get; set; }
        [Parameter("bytes32", "name", 3, true )]
        public virtual byte[] Name { get; set; }
        [Parameter("uint256", "timestamp", 4, false )]
        public virtual BigInteger Timestamp { get; set; }
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

    public partial class LastCreatedWorldNameOutputDTO : LastCreatedWorldNameOutputDTOBase { }

    [FunctionOutput]
    public class LastCreatedWorldNameOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class LastCreatedWorldsAddressOutputDTO : LastCreatedWorldsAddressOutputDTOBase { }

    [FunctionOutput]
    public class LastCreatedWorldsAddressOutputDTOBase : IFunctionOutputDTO 
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





    public partial class WorldsOutputDTO : WorldsOutputDTOBase { }

    [FunctionOutput]
    public class WorldsOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }


}
