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

namespace Galleass3D.Contracts.NFT.ContractDefinition
{


    public partial class NFTDeployment : NFTDeploymentBase
    {
        public NFTDeployment() : base(BYTECODE) { }
        public NFTDeployment(string byteCode) : base(byteCode) { }
    }

    public class NFTDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50610a37806100206000396000f3fe608060405234801561001057600080fd5b50600436106100885760003560e01c806370a082311161005b57806370a0823114610225578063a8bd9c321461027d578063a9059cbb146102eb578063ddc6a1711461033957610088565b8063095ea7b31461008d5780631d36e06c146100db57806323b872dd146101495780636352211e146101b7575b600080fd5b6100d9600480360360408110156100a357600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291908035906020019092919050505061039f565b005b610107600480360360208110156100f157600080fd5b810190808035906020019092919050505061045f565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6101b56004803603606081101561015f57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610492565b005b6101e3600480360360208110156101cd57600080fd5b810190808035906020019092919050505061053b565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6102676004803603602081101561023b57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291905050506105b1565b6040518082815260200191505060405180910390f35b6102a96004803603602081101561029357600080fd5b81019080803590602001909291905050506105fa565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6103376004803603604081101561030157600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291908035906020019092919050505061062d565b005b6103856004803603604081101561034f57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803590602001909291905050506106c2565b604051808215151515815260200191505060405180910390f35b6103a933826106d6565b6103b257600080fd5b6103bc8183610741565b7fb497174632623317507c114082fd64c660b4313b9375d4c99fd6d9f5067079db338383604051808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001828152602001935050505060405180910390a15050565b60006020528060005260406000206000915054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff1614156104cc57600080fd5b3073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff16141561050557600080fd5b61050f3382610797565b61051857600080fd5b61052283826106d6565b61052b57600080fd5b610536838383610803565b505050565b600080600083815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff169050600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff1614156105ac57600080fd5b919050565b6000600160008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020549050919050565b60026020528060005260406000206000915054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff16141561066757600080fd5b3073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff1614156106a057600080fd5b6106aa33826106d6565b6106b357600080fd5b6106be338383610803565b5050565b60006106ce8383610797565b905092915050565b60008273ffffffffffffffffffffffffffffffffffffffff1660008084815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1614905092915050565b806002600084815260200190815260200160002060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505050565b60008273ffffffffffffffffffffffffffffffffffffffff166002600084815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1614905092915050565b600160008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020600081548092919060010191905055508160008083815260200190815260200160002060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550600073ffffffffffffffffffffffffffffffffffffffff168373ffffffffffffffffffffffffffffffffffffffff161461095e57600160008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008154809291906001900391905055506002600082815260200190815260200160002060006101000a81549073ffffffffffffffffffffffffffffffffffffffff02191690555b7ffd19e66d1a4315847e95661bab80aff36f6801c5b2eeeca82491034bd7660abe838383604051808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001828152602001935050505060405180910390a150505056fea265627a7a72315820a01c44682df6be050761d538dc0b09f31d9c1699c955f02dccdd5f69976a5e5464736f6c634300050d0032";
        public NFTDeploymentBase() : base(BYTECODE) { }
        public NFTDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class TokenIndexToApprovedFunction : TokenIndexToApprovedFunctionBase { }

    [Function("tokenIndexToApproved", "address")]
    public class TokenIndexToApprovedFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class TokenIndexToOwnerFunction : TokenIndexToOwnerFunctionBase { }

    [Function("tokenIndexToOwner", "address")]
    public class TokenIndexToOwnerFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class TransferFunction : TransferFunctionBase { }

    [Function("transfer")]
    public class TransferFunctionBase : FunctionMessage
    {
        [Parameter("address", "_to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "_tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class TransferFromFunction : TransferFromFunctionBase { }

    [Function("transferFrom")]
    public class TransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "_from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "_to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "_tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class ApproveFunction : ApproveFunctionBase { }

    [Function("approve")]
    public class ApproveFunctionBase : FunctionMessage
    {
        [Parameter("address", "_to", 1)]
        public virtual string To { get; set; }
        [Parameter("uint256", "_tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class BalanceOfFunction : BalanceOfFunctionBase { }

    [Function("balanceOf", "uint256")]
    public class BalanceOfFunctionBase : FunctionMessage
    {
        [Parameter("address", "_owner", 1)]
        public virtual string Owner { get; set; }
    }

    public partial class OwnerOfFunction : OwnerOfFunctionBase { }

    [Function("ownerOf", "address")]
    public class OwnerOfFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class AllowanceFunction : AllowanceFunctionBase { }

    [Function("allowance", "bool")]
    public class AllowanceFunctionBase : FunctionMessage
    {
        [Parameter("address", "_claimant", 1)]
        public virtual string Claimant { get; set; }
        [Parameter("uint256", "_tokenId", 2)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class NFTApprovalEventDTO : NFTApprovalEventDTOBase { }

    [Event("NFTApproval")]
    public class NFTApprovalEventDTOBase : IEventDTO
    {
        [Parameter("address", "owner", 1, false )]
        public virtual string Owner { get; set; }
        [Parameter("address", "approved", 2, false )]
        public virtual string Approved { get; set; }
        [Parameter("uint256", "tokenId", 3, false )]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class NFTTransferEventDTO : NFTTransferEventDTOBase { }

    [Event("NFTTransfer")]
    public class NFTTransferEventDTOBase : IEventDTO
    {
        [Parameter("address", "from", 1, false )]
        public virtual string From { get; set; }
        [Parameter("address", "to", 2, false )]
        public virtual string To { get; set; }
        [Parameter("uint256", "tokenId", 3, false )]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class TokenIndexToApprovedOutputDTO : TokenIndexToApprovedOutputDTOBase { }

    [FunctionOutput]
    public class TokenIndexToApprovedOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }

    public partial class TokenIndexToOwnerOutputDTO : TokenIndexToOwnerOutputDTOBase { }

    [FunctionOutput]
    public class TokenIndexToOwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }







    public partial class BalanceOfOutputDTO : BalanceOfOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "count", 1)]
        public virtual BigInteger Count { get; set; }
    }

    public partial class OwnerOfOutputDTO : OwnerOfOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
    }

    public partial class AllowanceOutputDTO : AllowanceOutputDTOBase { }

    [FunctionOutput]
    public class AllowanceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }
}
