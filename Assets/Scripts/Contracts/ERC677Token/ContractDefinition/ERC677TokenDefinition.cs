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

namespace Galleass3D.Contracts.ERC677Token.ContractDefinition
{


    public partial class ERC677TokenDeployment : ERC677TokenDeploymentBase
    {
        public ERC677TokenDeployment() : base(BYTECODE) { }
        public ERC677TokenDeployment(string byteCode) : base(byteCode) { }
    }

    public class ERC677TokenDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50610e80806100206000396000f3fe608060405234801561001057600080fd5b50600436106100935760003560e01c80634000aea0116100665780634000aea01461020857806370a0823114610305578063a457c2d71461035d578063a9059cbb146103c3578063dd62ed3e1461042957610093565b8063095ea7b31461009857806318160ddd146100fe57806323b872dd1461011c57806339509351146101a2575b600080fd5b6100e4600480360360408110156100ae57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803590602001909291905050506104a1565b604051808215151515815260200191505060405180910390f35b6101066104b8565b6040518082815260200191505060405180910390f35b6101886004803603606081101561013257600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803590602001909291905050506104c2565b604051808215151515815260200191505060405180910390f35b6101ee600480360360408110156101b857600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610573565b604051808215151515815260200191505060405180910390f35b6102eb6004803603606081101561021e57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803590602001909291908035906020019064010000000081111561026557600080fd5b82018360208201111561027757600080fd5b8035906020019184600183028401116401000000008311171561029957600080fd5b91908080601f016020809104026020016040519081016040528093929190818152602001838380828437600081840152601f19601f820116905080830192505050505050509192919290505050610618565b604051808215151515815260200191505060405180910390f35b6103476004803603602081101561031b57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610790565b6040518082815260200191505060405180910390f35b6103a96004803603604081101561037357600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803590602001909291905050506107d8565b604051808215151515815260200191505060405180910390f35b61040f600480360360408110156103d957600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291908035906020019092919050505061087d565b604051808215151515815260200191505060405180910390f35b61048b6004803603604081101561043f57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610894565b6040518082815260200191505060405180910390f35b60006104ae33848461091b565b6001905092915050565b6000600254905090565b60006104cf848484610a7a565b610568843361056385600160008a73ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060003373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054610c4490919063ffffffff16565b61091b565b600190509392505050565b600061060e338461060985600160003373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008973ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054610c6490919063ffffffff16565b61091b565b6001905092915050565b600083600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff161415801561068457503073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff1614155b61068d57600080fd5b610697858561087d565b508473ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff167fce8124fd2ae9fd7904103e5a9ebe88b527b9ca0e32a32fd497845c82706542d386866040518083815260200180602001828103825283818151815260200191508051906020019080838360005b8381101561072f578082015181840152602081019050610714565b50505050905090810190601f16801561075c5780820380516001836020036101000a031916815260200191505b50935050505060405180910390a361077385610c83565b1561078457610783858585610c96565b5b60019150509392505050565b60008060008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020549050919050565b6000610873338461086e85600160003373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008973ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054610c4490919063ffffffff16565b61091b565b6001905092915050565b600061088a338484610a7a565b6001905092915050565b6000600160008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054905092915050565b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff16141561095557600080fd5b600073ffffffffffffffffffffffffffffffffffffffff168373ffffffffffffffffffffffffffffffffffffffff16141561098f57600080fd5b80600160008573ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020819055508173ffffffffffffffffffffffffffffffffffffffff168373ffffffffffffffffffffffffffffffffffffffff167f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925836040518082815260200191505060405180910390a3505050565b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff161415610ab457600080fd5b610b05816000808673ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054610c4490919063ffffffff16565b6000808573ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002081905550610b98816000808573ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054610c6490919063ffffffff16565b6000808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020819055508173ffffffffffffffffffffffffffffffffffffffff168373ffffffffffffffffffffffffffffffffffffffff167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef836040518082815260200191505060405180910390a3505050565b600082821115610c5357600080fd5b600082840390508091505092915050565b600080828401905083811015610c7957600080fd5b8091505092915050565b600080823b905060008111915050919050565b82600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff1614158015610d0057503073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff1614155b610d0957600080fd5b60008490508073ffffffffffffffffffffffffffffffffffffffff1663a4c0ed363386866040518463ffffffff1660e01b8152600401808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200183815260200180602001828103825283818151815260200191508051906020019080838360005b83811015610db4578082015181840152602081019050610d99565b50505050905090810190601f168015610de15780820380516001836020036101000a031916815260200191505b5094505050505060206040518083038186803b158015610e0057600080fd5b505afa158015610e14573d6000803e3d6000fd5b505050506040513d6020811015610e2a57600080fd5b8101908080519060200190929190505050610e4457600080fd5b505050505056fea265627a7a72315820406f5834eb39d23f84dc87d75a1ae611d0293196dc7fcda5d3f21a6f490fec7c64736f6c634300050d0032";
        public ERC677TokenDeploymentBase() : base(BYTECODE) { }
        public ERC677TokenDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class AllowanceFunction : AllowanceFunctionBase { }

    [Function("allowance", "uint256")]
    public class AllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("address", "spender", 2)]
        public virtual string Spender { get; set; }
    }

    public partial class ApproveFunction : ApproveFunctionBase { }

    [Function("approve", "bool")]
    public class ApproveFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender", 1)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "value", 2)]
        public virtual BigInteger Value { get; set; }
    }

    public partial class BalanceOfFunction : BalanceOfFunctionBase { }

    [Function("balanceOf", "uint256")]
    public class BalanceOfFunctionBase : FunctionMessage
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
    }

    public partial class DecreaseAllowanceFunction : DecreaseAllowanceFunctionBase { }

    [Function("decreaseAllowance", "bool")]
    public class DecreaseAllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender", 1)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "subtractedValue", 2)]
        public virtual BigInteger SubtractedValue { get; set; }
    }

    public partial class IncreaseAllowanceFunction : IncreaseAllowanceFunctionBase { }

    [Function("increaseAllowance", "bool")]
    public class IncreaseAllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "spender", 1)]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "addedValue", 2)]
        public virtual BigInteger AddedValue { get; set; }
    }

    public partial class TotalSupplyFunction : TotalSupplyFunctionBase { }

    [Function("totalSupply", "uint256")]
    public class TotalSupplyFunctionBase : FunctionMessage
    {

    }

    public partial class TransferFunction : TransferFunctionBase { }

    [Function("transfer", "bool")]
    public class TransferFunctionBase : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "value", 2)]
        public virtual BigInteger Value { get; set; }
    }

    public partial class TransferFromFunction : TransferFromFunctionBase { }

    [Function("transferFrom", "bool")]
    public class TransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "value", 3)]
        public virtual BigInteger Value { get; set; }
    }

    public partial class TransferAndCallFunction : TransferAndCallFunctionBase { }

    [Function("transferAndCall", "bool")]
    public class TransferAndCallFunctionBase : FunctionMessage
    {
        [Parameter("address", "_to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "_value", 2)]
        public virtual BigInteger Value { get; set; }
        [Parameter("bytes", "_data", 3)]
        public virtual byte[] Data { get; set; }
    }

    public partial class ApprovalEventDTO : ApprovalEventDTOBase { }

    [Event("Approval")]
    public class ApprovalEventDTOBase : IEventDTO
    {
        [Parameter("address", "owner", 1, true )]
        public virtual string Owner { get; set; }
        [Parameter("address", "spender", 2, true )]
        public virtual string Spender { get; set; }
        [Parameter("uint256", "value", 3, false )]
        public virtual BigInteger Value { get; set; }
    }

    public partial class TransferEventDTO : TransferEventDTOBase { }

    [Event("Transfer")]
    public class TransferEventDTOBase : IEventDTO
    {
        [Parameter("address", "from", 1, true )]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2, true )]
        public virtual string To { get; set; }
        [Parameter("uint256", "value", 3, false )]
        public virtual BigInteger Value { get; set; }
    }

    public partial class TransferAndCallEventDTO : TransferAndCallEventDTOBase { }

    [Event("TransferAndCall")]
    public class TransferAndCallEventDTOBase : IEventDTO
    {
        [Parameter("address", "from", 1, true )]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2, true )]
        public virtual string To { get; set; }
        [Parameter("uint256", "value", 3, false )]
        public virtual BigInteger Value { get; set; }
        [Parameter("bytes", "data", 4, false )]
        public virtual byte[] Data { get; set; }
    }

    public partial class AllowanceOutputDTO : AllowanceOutputDTOBase { }

    [FunctionOutput]
    public class AllowanceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }



    public partial class BalanceOfOutputDTO : BalanceOfOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }





    public partial class TotalSupplyOutputDTO : TotalSupplyOutputDTOBase { }

    [FunctionOutput]
    public class TotalSupplyOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }






}
