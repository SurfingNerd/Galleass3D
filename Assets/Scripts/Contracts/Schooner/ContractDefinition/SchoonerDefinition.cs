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

namespace Galleass3D.Contracts.Schooner.ContractDefinition
{


    public partial class SchoonerDeployment : SchoonerDeploymentBase
    {
        public SchoonerDeployment() : base(BYTECODE) { }
        public SchoonerDeployment(string byteCode) : base(byteCode) { }
    }

    public class SchoonerDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b506040516125d53803806125d58339818101604052602081101561003357600080fd5b810190808051906020019092919050505080336000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055506000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16600073ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a380600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505061014b6102ad565b6040518060c00160405280600061ffff168152602001600061ffff168152602001600060ff168152602001600061ffff168152602001600061ffff168152602001600067ffffffffffffffff16815250905060058190806001815401808255809150509060018203906000526020600020016000909192909190915060008201518160000160006101000a81548161ffff021916908361ffff16021790555060208201518160000160026101000a81548161ffff021916908361ffff16021790555060408201518160000160046101000a81548160ff021916908360ff16021790555060608201518160000160056101000a81548161ffff021916908361ffff16021790555060808201518160000160076101000a81548161ffff021916908361ffff16021790555060a08201518160000160096101000a81548167ffffffffffffffff021916908367ffffffffffffffff1602179055505050505050610300565b6040518060c00160405280600061ffff168152602001600061ffff168152602001600060ff168152602001600061ffff168152602001600061ffff168152602001600067ffffffffffffffff1681525090565b6122c68061030f6000396000f3fe608060405234801561001057600080fd5b50600436106101a95760003560e01c80638da5cb5b116100f9578063b0619e8511610097578063e16c7d9811610071578063e16c7d981461095d578063e4b50cb8146109cb578063f2fde38b14610a9d578063f3ccaac014610ae1576101a9565b8063b0619e851461086b578063ba86943e146108d1578063ddc6a171146108f7576101a9565b806395d89b41116100d357806395d89b41146106c65780639e281a9814610749578063a8bd9c32146107af578063a9059cbb1461081d576101a9565b80638da5cb5b1461063c5780638e1a55fc146106865780638f32d59b146106a4576101a9565b80632e1a7d4d1161016657806370a082311161014057806370a08231146104d3578063715018a61461052b5780637a2a3931146105355780638462151c146105a3576101a9565b80632e1a7d4d146103c35780633319bf1a146104095780636352211e14610465576101a9565b806306fdde03146101ae578063095ea7b31461023157806318160ddd1461027f5780631d36e06c1461029d57806323b872dd1461030b5780632ce643f214610379575b600080fd5b6101b6610aff565b6040518080602001828103825283818151815260200191508051906020019080838360005b838110156101f65780820151818401526020810190506101db565b50505050905090810190601f1680156102235780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b61027d6004803603604081101561024757600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610b38565b005b610287610bf8565b6040518082815260200191505060405180910390f35b6102c9600480360360208110156102b357600080fd5b8101908080359060200190929190505050610c08565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6103776004803603606081101561032157600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610c3b565b005b610381610ce4565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6103ef600480360360208110156103d957600080fd5b8101908080359060200190929190505050610d0a565b604051808215151515815260200191505060405180910390f35b61044b6004803603602081101561041f57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610e57565b604051808215151515815260200191505060405180910390f35b6104916004803603602081101561047b57600080fd5b8101908080359060200190929190505050610efd565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b610515600480360360208110156104e957600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610f74565b6040518082815260200191505060405180910390f35b610533610fbd565b005b6105a16004803603606081101561054b57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff1690602001909291908035906020019092919050505061108d565b005b6105e5600480360360208110156105b957600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050611156565b6040518080602001828103825283818151815260200191508051906020019060200280838360005b8381101561062857808201518184015260208101905061060d565b505050509050019250505060405180910390f35b61064461129e565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b61068e6112c7565b6040518082815260200191505060405180910390f35b6106ac61152c565b604051808215151515815260200191505060405180910390f35b6106ce611583565b6040518080602001828103825283818151815260200191508051906020019080838360005b8381101561070e5780820151818401526020810190506106f3565b50505050905090810190601f16801561073b5780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b6107956004803603604081101561075f57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803590602001909291905050506115bc565b604051808215151515815260200191505060405180910390f35b6107db600480360360208110156107c557600080fd5b810190808035906020019092919050505061176d565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6108696004803603604081101561083357600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803590602001909291905050506117a0565b005b6108b76004803603604081101561088157600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050611835565b604051808215151515815260200191505060405180910390f35b6108d9611926565b604051808261ffff1661ffff16815260200191505060405180910390f35b6109436004803603604081101561090d57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291908035906020019092919050505061192b565b604051808215151515815260200191505060405180910390f35b6109896004803603602081101561097357600080fd5b810190808035906020019092919050505061193f565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6109f7600480360360208110156109e157600080fd5b81019080803590602001909291905050506119fb565b604051808873ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018761ffff1661ffff1681526020018661ffff1661ffff1681526020018560ff1660ff1681526020018461ffff1661ffff1681526020018361ffff1661ffff1681526020018267ffffffffffffffff1667ffffffffffffffff16815260200197505050505050505060405180910390f35b610adf60048036036020811015610ab357600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050611b4e565b005b610ae9611b6b565b6040518082815260200191505060405180910390f35b6040518060400160405280601181526020017f47616c6c65617373205363686f6f6e657200000000000000000000000000000081525081565b610b423382611b8f565b610b4b57600080fd5b610b558183611bfb565b7fb497174632623317507c114082fd64c660b4313b9375d4c99fd6d9f5067079db338383604051808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001828152602001935050505060405180910390a15050565b6000600160058054905003905090565b60026020528060005260406000206000915054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff161415610c7557600080fd5b3073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff161415610cae57600080fd5b610cb83382611c51565b610cc157600080fd5b610ccb8382611b8f565b610cd457600080fd5b610cdf838383611cbd565b505050565b600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b6000610d1461152c565b610d1d57600080fd5b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905060016003811115610d5157fe5b8173ffffffffffffffffffffffffffffffffffffffff1663b0e315816040518163ffffffff1660e01b815260040160206040518083038186803b158015610d9757600080fd5b505afa158015610dab573d6000803e3d6000fd5b505050506040513d6020811015610dc157600080fd5b81019080805190602001909291905050506003811115610ddd57fe5b14610de757600080fd5b823073ffffffffffffffffffffffffffffffffffffffff16311015610e0b57600080fd5b610e1361129e565b73ffffffffffffffffffffffffffffffffffffffff166108fc849081150290604051600060405180830381858888f19350505050610e4d57fe5b6001915050919050565b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614610eb357600080fd5b81600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555060019050919050565b60006002600083815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff169050600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff161415610f6f57600080fd5b919050565b6000600360008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020549050919050565b610fc561152c565b610fce57600080fd5b600073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a360008060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550565b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff1614156110c757600080fd5b3073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff16141561110057600080fd5b61110a8382611b8f565b61111357600080fd5b61113d337f7472616e736665725363686f6f6e657200000000000000000000000000000000611835565b61114657600080fd5b611151838383611cbd565b505050565b6060600061116383610f74565b905060008114156111a757600060405190808252806020026020018201604052801561119e5781602001602082028038833980820191505090505b50915050611299565b6060816040519080825280602002602001820160405280156111d85781602001602082028038833980820191505090505b50905060006111e5610bf8565b905060008090506000600190505b828111611290578673ffffffffffffffffffffffffffffffffffffffff166002600083815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff161415611283578084838151811061126e57fe5b60200260200101818152505081806001019250505b80806001019150506111f3565b83955050505050505b919050565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905090565b60007f5363686f6f6e65720000000000000000000000000000000000000000000000006000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98836040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b15801561136257600080fd5b505afa158015611376573d6000803e3d6000fd5b505050506040513d602081101561138c57600080fd5b810190808051906020019092919050505073ffffffffffffffffffffffffffffffffffffffff163073ffffffffffffffffffffffffffffffffffffffff16146113d457600080fd5b6113fe337f6275696c645363686f6f6e657200000000000000000000000000000000000000611835565b61140757600080fd5b611437337f54696d6265720000000000000000000000000000000000000000000000000000600661ffff16611ebd565b61144057600080fd5b6000600490506000610600905060006001905060006102009050600061020090507fff2425612e81cfb145af3e470a1d1f4bc7e7ea5fd0e9e0ff72ea92201b0a3e5c338686868686604051808773ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018661ffff1661ffff1681526020018561ffff1661ffff1681526020018460ff1660ff1681526020018361ffff1661ffff1681526020018261ffff1661ffff168152602001965050505050505060405180910390a1611520338686868686611fc6565b97505050505050505090565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614905090565b6040518060400160405280600a81526020017f475f5343484f4f4e45520000000000000000000000000000000000000000000081525081565b60006115c661152c565b6115cf57600080fd5b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690506001600381111561160357fe5b8173ffffffffffffffffffffffffffffffffffffffff1663b0e315816040518163ffffffff1660e01b815260040160206040518083038186803b15801561164957600080fd5b505afa15801561165d573d6000803e3d6000fd5b505050506040513d602081101561167357600080fd5b8101908080519060200190929190505050600381111561168f57fe5b1461169957600080fd5b60008490508073ffffffffffffffffffffffffffffffffffffffff1663a9059cbb33866040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200182815260200192505050602060405180830381600087803b15801561172557600080fd5b505af1158015611739573d6000803e3d6000fd5b505050506040513d602081101561174f57600080fd5b81019080805190602001909291905050505060019250505092915050565b60046020528060005260406000206000915054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff1614156117da57600080fd5b3073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff16141561181357600080fd5b61181d3382611b8f565b61182657600080fd5b611831338383611cbd565b5050565b600080600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663b0619e8585856040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018281526020019250505060206040518083038186803b1580156118e257600080fd5b505afa1580156118f6573d6000803e3d6000fd5b505050506040513d602081101561190c57600080fd5b810190808051906020019092919050505091505092915050565b600681565b60006119378383611c51565b905092915050565b600080600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98846040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b1580156119b857600080fd5b505afa1580156119cc573d6000803e3d6000fd5b505050506040513d60208110156119e257600080fd5b8101908080519060200190929190505050915050919050565b60008060008060008060006002600089815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1660058981548110611a4757fe5b9060005260206000200160000160009054906101000a900461ffff1660058a81548110611a7057fe5b9060005260206000200160000160029054906101000a900461ffff1660058b81548110611a9957fe5b9060005260206000200160000160049054906101000a900460ff1660058c81548110611ac157fe5b9060005260206000200160000160059054906101000a900461ffff1660058d81548110611aea57fe5b9060005260206000200160000160079054906101000a900461ffff1660058e81548110611b1357fe5b9060005260206000200160000160099054906101000a900467ffffffffffffffff169650965096509650965096509650919395979092949650565b611b5661152c565b611b5f57600080fd5b611b6881612146565b50565b7f7363686f6f6e657200000000000000000000000000000000000000000000000081565b60008273ffffffffffffffffffffffffffffffffffffffff166002600084815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1614905092915050565b806004600084815260200190815260200160002060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505050565b60008273ffffffffffffffffffffffffffffffffffffffff166004600084815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1614905092915050565b600360008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008154809291906001019190505550816002600083815260200190815260200160002060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550600073ffffffffffffffffffffffffffffffffffffffff168373ffffffffffffffffffffffffffffffffffffffff1614611e1957600360008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008154809291906001900391905055506004600082815260200190815260200160002060006101000a81549073ffffffffffffffffffffffffffffffffffffffff02191690555b7ffd19e66d1a4315847e95661bab80aff36f6801c5b2eeeca82491034bd7660abe838383604051808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001828152602001935050505060405180910390a1505050565b6000611ec88361193f565b73ffffffffffffffffffffffffffffffffffffffff166323b872dd8530856040518463ffffffff1660e01b8152600401808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018281526020019350505050602060405180830381600087803b158015611f8257600080fd5b505af1158015611f96573d6000803e3d6000fd5b505050506040513d6020811015611fac57600080fd5b810190808051906020019092919050505090509392505050565b6000611fd061223e565b6040518060c001604052808861ffff1681526020018761ffff1681526020018660ff1681526020018561ffff1681526020018461ffff1681526020014267ffffffffffffffff1681525090506000600160058390806001815401808255809150509060018203906000526020600020016000909192909190915060008201518160000160006101000a81548161ffff021916908361ffff16021790555060208201518160000160026101000a81548161ffff021916908361ffff16021790555060408201518160000160046101000a81548160ff021916908360ff16021790555060608201518160000160056101000a81548161ffff021916908361ffff16021790555060808201518160000160076101000a81548161ffff021916908361ffff16021790555060a08201518160000160096101000a81548167ffffffffffffffff021916908367ffffffffffffffff160217905550505003905061213760008a83611cbd565b80925050509695505050505050565b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff16141561218057600080fd5b8073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a3806000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555050565b6040518060c00160405280600061ffff168152602001600061ffff168152602001600060ff168152602001600061ffff168152602001600061ffff168152602001600067ffffffffffffffff168152509056fea265627a7a72315820175189c3f475e5941b7c61d74410a8bd133eefcf92e64578bd7fbacdef178ec364736f6c634300050d0032";
        public SchoonerDeploymentBase() : base(BYTECODE) { }
        public SchoonerDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "_galleass", 1)]
        public virtual string Galleass { get; set; }
    }

    public partial class TIMBERTOBUILDFunction : TIMBERTOBUILDFunctionBase { }

    [Function("TIMBERTOBUILD", "uint16")]
    public class TIMBERTOBUILDFunctionBase : FunctionMessage
    {

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

    public partial class ImageFunction : ImageFunctionBase { }

    [Function("image", "bytes32")]
    public class ImageFunctionBase : FunctionMessage
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

    public partial class OwnerOfFunction : OwnerOfFunctionBase { }

    [Function("ownerOf", "address")]
    public class OwnerOfFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_tokenId", 1)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class RenounceOwnershipFunction : RenounceOwnershipFunctionBase { }

    [Function("renounceOwnership")]
    public class RenounceOwnershipFunctionBase : FunctionMessage
    {

    }

    public partial class SymbolFunction : SymbolFunctionBase { }

    [Function("symbol", "string")]
    public class SymbolFunctionBase : FunctionMessage
    {

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

    public partial class BuildFunction : BuildFunctionBase { }

    [Function("build", "uint256")]
    public class BuildFunctionBase : FunctionMessage
    {

    }

    public partial class GalleassetTransferFromFunction : GalleassetTransferFromFunctionBase { }

    [Function("galleassetTransferFrom")]
    public class GalleassetTransferFromFunctionBase : FunctionMessage
    {
        [Parameter("address", "_from", 1)]
        public virtual string From { get; set; }
        [Parameter("address", "_to", 2)]
        public virtual string To { get; set; }
        [Parameter("uint256", "_tokenId", 3)]
        public virtual BigInteger TokenId { get; set; }
    }

    public partial class TotalSupplyFunction : TotalSupplyFunctionBase { }

    [Function("totalSupply", "uint256")]
    public class TotalSupplyFunctionBase : FunctionMessage
    {

    }

    public partial class GetTokenFunction : GetTokenFunctionBase { }

    [Function("getToken", typeof(GetTokenOutputDTO))]
    public class GetTokenFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_id", 1)]
        public virtual BigInteger Id { get; set; }
    }

    public partial class TokensOfOwnerFunction : TokensOfOwnerFunctionBase { }

    [Function("tokensOfOwner", "uint256[]")]
    public class TokensOfOwnerFunctionBase : FunctionMessage
    {
        [Parameter("address", "_owner", 1)]
        public virtual string Owner { get; set; }
    }

    public partial class BuildEventDTO : BuildEventDTOBase { }

    [Event("Build")]
    public class BuildEventDTOBase : IEventDTO
    {
        [Parameter("address", "_sender", 1, false )]
        public virtual string Sender { get; set; }
        [Parameter("uint16", "strength", 2, false )]
        public virtual ushort Strength { get; set; }
        [Parameter("uint16", "speed", 3, false )]
        public virtual ushort Speed { get; set; }
        [Parameter("uint8", "luck", 4, false )]
        public virtual byte Luck { get; set; }
        [Parameter("uint16", "power", 5, false )]
        public virtual ushort Power { get; set; }
        [Parameter("uint16", "defense", 6, false )]
        public virtual ushort Defense { get; set; }
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

    public partial class OwnershipTransferredEventDTO : OwnershipTransferredEventDTOBase { }

    [Event("OwnershipTransferred")]
    public class OwnershipTransferredEventDTOBase : IEventDTO
    {
        [Parameter("address", "previousOwner", 1, true )]
        public virtual string PreviousOwner { get; set; }
        [Parameter("address", "newOwner", 2, true )]
        public virtual string NewOwner { get; set; }
    }

    public partial class TIMBERTOBUILDOutputDTO : TIMBERTOBUILDOutputDTOBase { }

    [FunctionOutput]
    public class TIMBERTOBUILDOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint16", "", 1)]
        public virtual ushort ReturnValue1 { get; set; }
    }

    public partial class AllowanceOutputDTO : AllowanceOutputDTOBase { }

    [FunctionOutput]
    public class AllowanceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }



    public partial class BalanceOfOutputDTO : BalanceOfOutputDTOBase { }

    [FunctionOutput]
    public class BalanceOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "count", 1)]
        public virtual BigInteger Count { get; set; }
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

    public partial class ImageOutputDTO : ImageOutputDTOBase { }

    [FunctionOutput]
    public class ImageOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
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

    public partial class OwnerOfOutputDTO : OwnerOfOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOfOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
    }



    public partial class SymbolOutputDTO : SymbolOutputDTOBase { }

    [FunctionOutput]
    public class SymbolOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("string", "", 1)]
        public virtual string ReturnValue1 { get; set; }
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

















    public partial class TotalSupplyOutputDTO : TotalSupplyOutputDTOBase { }

    [FunctionOutput]
    public class TotalSupplyOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class GetTokenOutputDTO : GetTokenOutputDTOBase { }

    [FunctionOutput]
    public class GetTokenOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("uint16", "strength", 2)]
        public virtual ushort Strength { get; set; }
        [Parameter("uint16", "speed", 3)]
        public virtual ushort Speed { get; set; }
        [Parameter("uint8", "luck", 4)]
        public virtual byte Luck { get; set; }
        [Parameter("uint16", "power", 5)]
        public virtual ushort Power { get; set; }
        [Parameter("uint16", "defense", 6)]
        public virtual ushort Defense { get; set; }
        [Parameter("uint64", "birth", 7)]
        public virtual ulong Birth { get; set; }
    }

    public partial class TokensOfOwnerOutputDTO : TokensOfOwnerOutputDTOBase { }

    [FunctionOutput]
    public class TokensOfOwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256[]", "", 1)]
        public virtual List<BigInteger> ReturnValue1 { get; set; }
    }
}
