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

namespace Galleass3D.Contracts.Market.ContractDefinition
{


    public partial class MarketDeployment : MarketDeploymentBase
    {
        public MarketDeployment() : base(BYTECODE) { }
        public MarketDeployment(string byteCode) : base(byteCode) { }
    }

    public class MarketDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b5060405161294d38038061294d8339818101604052602081101561003357600080fd5b81019080805190602001909291905050508080336000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055506000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16600073ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a380600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505050506127f8806101556000396000f3fe608060405234801561001057600080fd5b50600436106101165760003560e01c80638f32d59b116100a2578063b0619e8511610071578063b0619e8514610681578063cc549a8d146106e7578063dd63133a14610774578063e16c7d9814610803578063f2fde38b1461087157610116565b80638f32d59b1461047b57806396af3d8a1461049d5780639e281a981461051e578063a4c0ed361461058457610116565b806355b9bd8d116100e957806355b9bd8d146102885780635f5e38b61461030957806365d2724814610398578063715018a6146104275780638da5cb5b1461043157610116565b80632ce643f21461011b5780632e1a7d4d146101655780633319bf1a146101ab578063534a5ab814610207575b600080fd5b6101236108b5565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6101916004803603602081101561017b57600080fd5b81019080803590602001909291905050506108db565b604051808215151515815260200191505060405180910390f35b6101ed600480360360208110156101c157600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610a28565b604051808215151515815260200191505060405180910390f35b6102726004803603608081101561021d57600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610ace565b6040518082815260200191505060405180910390f35b6102f36004803603608081101561029e57600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610b0d565b6040518082815260200191505060405180910390f35b61037e600480360360a081101561031f57600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610b4c565b604051808215151515815260200191505060405180910390f35b61040d600480360360a08110156103ae57600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610d9e565b604051808215151515815260200191505060405180910390f35b61042f610ff0565b005b6104396110c0565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6104836110e9565b604051808215151515815260200191505060405180910390f35b610508600480360360808110156104b357600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050611140565b6040518082815260200191505060405180910390f35b61056a6004803603604081101561053457600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291908035906020019092919050505061117f565b604051808215151515815260200191505060405180910390f35b6106676004803603606081101561059a57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190803590602001906401000000008111156105e157600080fd5b8201836020820111156105f357600080fd5b8035906020019184600183028401116401000000008311171561061557600080fd5b91908080601f016020809104026020016040519081016040528093929190818152602001838380828437600081840152601f19601f820116905080830192505050505050509192919290505050611330565b604051808215151515815260200191505060405180910390f35b6106cd6004803603604081101561069757600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291908035906020019092919050505061163c565b604051808215151515815260200191505060405180910390f35b610732600480360360608110156106fd57600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff16906020019092919050505061172d565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6107e9600480360360a081101561078a57600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff1690602001909291908035906020019092919050505061177c565b604051808215151515815260200191505060405180910390f35b61082f6004803603602081101561081957600080fd5b8101908080359060200190929190505050611964565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6108b36004803603602081101561088757600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050611a20565b005b600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b60006108e56110e9565b6108ee57600080fd5b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690506001600381111561092257fe5b8173ffffffffffffffffffffffffffffffffffffffff1663b0e315816040518163ffffffff1660e01b815260040160206040518083038186803b15801561096857600080fd5b505afa15801561097c573d6000803e3d6000fd5b505050506040513d602081101561099257600080fd5b810190808051906020019092919050505060038111156109ae57fe5b146109b857600080fd5b823073ffffffffffffffffffffffffffffffffffffffff163110156109dc57600080fd5b6109e46110c0565b73ffffffffffffffffffffffffffffffffffffffff166108fc849081150290604051600060405180830381858888f19350505050610a1e57fe5b6001915050919050565b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614610a8457600080fd5b81600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555060019050919050565b60046020528360005260406000206020528260005260406000206020528160005260406000206020528060005260406000206000935093505050505481565b60056020528360005260406000206020528260005260406000206020528160005260406000206020528060005260406000206000935093505050505481565b60007f4d61726b657400000000000000000000000000000000000000000000000000006000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98836040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b158015610be757600080fd5b505afa158015610bfb573d6000803e3d6000fd5b505050506040513d6020811015610c1157600080fd5b810190808051906020019092919050505073ffffffffffffffffffffffffffffffffffffffff163073ffffffffffffffffffffffffffffffffffffffff1614610c5957600080fd5b878787600260008461ffff1661ffff16815260200190815260200160002060008361ffff1661ffff16815260200190815260200160002060008260ff1660ff16815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614610cff57600080fd5b86600460008d61ffff1661ffff16815260200190815260200160002060008c61ffff1661ffff16815260200190815260200160002060008b60ff1660ff16815260200190815260200160002060008a73ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020019081526020016000208190555060019550505050505095945050505050565b60007f4d61726b657400000000000000000000000000000000000000000000000000006000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98836040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b158015610e3957600080fd5b505afa158015610e4d573d6000803e3d6000fd5b505050506040513d6020811015610e6357600080fd5b810190808051906020019092919050505073ffffffffffffffffffffffffffffffffffffffff163073ffffffffffffffffffffffffffffffffffffffff1614610eab57600080fd5b878787600260008461ffff1661ffff16815260200190815260200160002060008361ffff1661ffff16815260200190815260200160002060008260ff1660ff16815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614610f5157600080fd5b86600560008d61ffff1661ffff16815260200190815260200160002060008c61ffff1661ffff16815260200190815260200160002060008b60ff1660ff16815260200190815260200160002060008a73ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020019081526020016000208190555060019550505050505095945050505050565b610ff86110e9565b61100157600080fd5b600073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a360008060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905090565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614905090565b60036020528360005260406000206020528260005260406000206020528160005260406000206020528060005260406000206000935093505050505481565b60006111896110e9565b61119257600080fd5b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff169050600160038111156111c657fe5b8173ffffffffffffffffffffffffffffffffffffffff1663b0e315816040518163ffffffff1660e01b815260040160206040518083038186803b15801561120c57600080fd5b505afa158015611220573d6000803e3d6000fd5b505050506040513d602081101561123657600080fd5b8101908080519060200190929190505050600381111561125257fe5b1461125c57600080fd5b60008490508073ffffffffffffffffffffffffffffffffffffffff1663a9059cbb33866040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200182815260200192505050602060405180830381600087803b1580156112e857600080fd5b505af11580156112fc573d6000803e3d6000fd5b505050506040513d602081101561131257600080fd5b81019080805190602001909291905050505060019250505092915050565b60007f4d61726b657400000000000000000000000000000000000000000000000000006000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98836040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b1580156113cb57600080fd5b505afa1580156113df573d6000803e3d6000fd5b505050506040513d60208110156113f557600080fd5b810190808051906020019092919050505073ffffffffffffffffffffffffffffffffffffffff163073ffffffffffffffffffffffffffffffffffffffff161461143d57600080fd5b7f96bd57d3c3174096a8d69b378ddbbc106adbfcb63971c045e64b183faec8065033878787604051808573ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200183815260200180602001828103825283818151815260200191508051906020019080838360005b8381101561150c5780820151818401526020810190506114f1565b50505050905090810190601f1680156115395780820380516001836020036101000a031916815260200191505b509550505050505060405180910390a160008460008151811061155857fe5b602001015160f81c60f81b60f81c905060008160ff1614156115875761157f878787611a3d565b935050611633565b60018160ff1614156115a65761159e878787611a80565b935050611633565b60028160ff1614156115c5576115bd878787611dec565b935050611633565b6040517f08c379a000000000000000000000000000000000000000000000000000000000815260040180806020018281038252600e8152602001807f756e6b6e6f776e20616374696f6e00000000000000000000000000000000000081525060200191505060405180910390fd5b50509392505050565b600080600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663b0619e8585856040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018281526020019250505060206040518083038186803b1580156116e957600080fd5b505afa1580156116fd573d6000803e3d6000fd5b505050506040513d602081101561171357600080fd5b810190808051906020019092919050505091505092915050565b6002602052826000526040600020602052816000526040600020602052806000526040600020600092509250509054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b60006117a77f4c616e6400000000000000000000000000000000000000000000000000000000611964565b73ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16148061183357506118047f4c616e644c696200000000000000000000000000000000000000000000000000611964565b73ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16145b61183c57600080fd5b82600260008861ffff1661ffff16815260200190815260200160002060008761ffff1661ffff16815260200190815260200160002060008660ff1660ff16815260200190815260200160002060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055507f9ddbaf061101ada1338c64912dabc002f73b61a5652827b26a01864e55db68b286868686604051808561ffff1661ffff1681526020018461ffff1661ffff1681526020018360ff1660ff1681526020018273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200194505050505060405180910390a16001905095945050505050565b600080600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98846040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b1580156119dd57600080fd5b505afa1580156119f1573d6000803e3d6000fd5b505050506040513d6020811015611a0757600080fd5b8101908080519060200190929190505050915050919050565b611a286110e9565b611a3157600080fd5b611a3a8161214f565b50565b600080611a4983612247565b90506000611a56846122fe565b90506000611a63856123b5565b9050611a72838383338a6123d9565b600193505050509392505050565b6000611aab7f436f707065720000000000000000000000000000000000000000000000000000611964565b73ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614611ae257600080fd5b6000611aed83612247565b90506000611afa846122fe565b90506000611b07856123b5565b90506000611b16600687612574565b9050611b25848484338b6123d9565b6000600560008661ffff1661ffff16815260200190815260200160002060008561ffff1661ffff16815260200190815260200160002060008460ff1660ff16815260200190815260200160002060008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020019081526020016000205411611bba57600080fd5b611bc7848484848b6123d9565b6000600560008661ffff1661ffff16815260200190815260200160002060008561ffff1661ffff16815260200190815260200160002060008460ff1660ff16815260200190815260200160002060008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020548881611c5a57fe5b049050611c6a8585858585612619565b60008290508073ffffffffffffffffffffffffffffffffffffffff1663a9059cbb8b846040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200182815260200192505050602060405180830381600087803b158015611cf657600080fd5b505af1158015611d0a573d6000803e3d6000fd5b505050506040513d6020811015611d2057600080fd5b8101908080519060200190929190505050611d3a57600080fd5b7f24449f700af63cdb19b9de643e694328a8d9dfe98b867ac3436eccdf216467ee8686868c8787604051808761ffff1661ffff1681526020018661ffff1661ffff1681526020018560ff1660ff1681526020018481526020018373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001828152602001965050505050505060405180910390a1600196505050505050509392505050565b600080611df883612247565b90506000611e05846122fe565b90506000611e12856123b5565b90506000600460008561ffff1661ffff16815260200190815260200160002060008461ffff1661ffff16815260200190815260200160002060008360ff1660ff16815260200190815260200160002060003373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020019081526020016000205411611ea957600080fd5b611eb6838383338a6123d9565b7ff8753b3ef35e2a9a2103391ec2df237023c9949782e741708c283309916d40ef838383338a8c604051808761ffff1661ffff1681526020018661ffff1661ffff1681526020018560ff1660ff1681526020018473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018381526020018273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001965050505050505060405180910390a16000600460008561ffff1661ffff16815260200190815260200160002060008461ffff1661ffff16815260200190815260200160002060008360ff1660ff16815260200190815260200160002060003373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054870290506120478484846120417f436f707065720000000000000000000000000000000000000000000000000000611964565b85612619565b60006120727f436f707065720000000000000000000000000000000000000000000000000000611964565b90508073ffffffffffffffffffffffffffffffffffffffff1663a9059cbb8a846040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200182815260200192505050602060405180830381600087803b1580156120fb57600080fd5b505af115801561210f573d6000803e3d6000fd5b505050506040513d602081101561212557600080fd5b810190808051906020019092919050505061213f57600080fd5b6001955050505050509392505050565b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff16141561218957600080fd5b8073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a3806000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555050565b6000808260018151811061225757fe5b602001015160f81c60f81b7effffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff1916905060008360028151811061229557fe5b602001015160f81c60f81b7effffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff191690506008827dffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff1916901b91508060f01c8260f01c0192505050919050565b6000808260038151811061230e57fe5b602001015160f81c60f81b7effffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff1916905060008360048151811061234c57fe5b602001015160f81c60f81b7effffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff191690506008827dffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff1916901b91508060f01c8260f01c0192505050919050565b6000816005815181106123c457fe5b602001015160f81c60f81b60f81c9050919050565b80600360008761ffff1661ffff16815260200190815260200160002060008661ffff1661ffff16815260200190815260200160002060008560ff1660ff16815260200190815260200160002060008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020019081526020016000206000828254019250508190555080600360008761ffff1661ffff16815260200190815260200160002060008661ffff1661ffff16815260200190815260200160002060008560ff1660ff16815260200190815260200160002060008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054101561256d576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260098152602001807f4f766572666c6f773f000000000000000000000000000000000000000000000081525060200191505060405180910390fd5b5050505050565b6000806000905060006014850160ff16905060006001820390505b6001860360ff168160ff16111561260d576000858260ff16815181106125b157fe5b602001015160f81c60f81b7effffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff191660001c90506000600260018460ff168603030260100a820290508085019450828060019003935050505061258f565b82935050505092915050565b80600360008761ffff1661ffff16815260200190815260200160002060008661ffff1661ffff16815260200190815260200160002060008560ff1660ff16815260200190815260200160002060008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020019081526020016000205410156126fa576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040180806020018281038252602c815260200180612798602c913960400191505060405180910390fd5b80600360008761ffff1661ffff16815260200190815260200160002060008661ffff1661ffff16815260200190815260200160002060008560ff1660ff16815260200190815260200160002060008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008282540392505081905550505050505056fe546869732074696c6520646f6573206e6f74206861766520656e6f756768206f66207468697320746f6b656ea265627a7a72315820ac0d7c82c6476f2cd7072b9826038c5ad8d652141ea38366136485551a3069fa64736f6c634300050d0032";
        public MarketDeploymentBase() : base(BYTECODE) { }
        public MarketDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "_galleass", 1)]
        public virtual string Galleass { get; set; }
    }

    public partial class BuyPricesFunction : BuyPricesFunctionBase { }

    [Function("buyPrices", "uint256")]
    public class BuyPricesFunctionBase : FunctionMessage
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

    public partial class SellPricesFunction : SellPricesFunctionBase { }

    [Function("sellPrices", "uint256")]
    public class SellPricesFunctionBase : FunctionMessage
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

    public partial class SetBuyPriceFunction : SetBuyPriceFunctionBase { }

    [Function("setBuyPrice", "bool")]
    public class SetBuyPriceFunctionBase : FunctionMessage
    {
        [Parameter("uint16", "_x", 1)]
        public virtual ushort X { get; set; }
        [Parameter("uint16", "_y", 2)]
        public virtual ushort Y { get; set; }
        [Parameter("uint8", "_tile", 3)]
        public virtual byte Tile { get; set; }
        [Parameter("address", "_token", 4)]
        public virtual string Token { get; set; }
        [Parameter("uint256", "_price", 5)]
        public virtual BigInteger Price { get; set; }
    }

    public partial class SetSellPriceFunction : SetSellPriceFunctionBase { }

    [Function("setSellPrice", "bool")]
    public class SetSellPriceFunctionBase : FunctionMessage
    {
        [Parameter("uint16", "_x", 1)]
        public virtual ushort X { get; set; }
        [Parameter("uint16", "_y", 2)]
        public virtual ushort Y { get; set; }
        [Parameter("uint8", "_tile", 3)]
        public virtual byte Tile { get; set; }
        [Parameter("address", "_token", 4)]
        public virtual string Token { get; set; }
        [Parameter("uint256", "_price", 5)]
        public virtual BigInteger Price { get; set; }
    }

    public partial class OnTokenTransferFunction : OnTokenTransferFunctionBase { }

    [Function("onTokenTransfer", "bool")]
    public class OnTokenTransferFunctionBase : FunctionMessage
    {
        [Parameter("address", "_sender", 1)]
        public virtual string Sender { get; set; }
        [Parameter("uint256", "_amount", 2)]
        public virtual BigInteger Amount { get; set; }
        [Parameter("bytes", "_data", 3)]
        public virtual byte[] Data { get; set; }
    }

    public partial class BuyEventDTO : BuyEventDTOBase { }

    [Event("Buy")]
    public class BuyEventDTOBase : IEventDTO
    {
        [Parameter("uint16", "_x", 1, false )]
        public virtual ushort X { get; set; }
        [Parameter("uint16", "_y", 2, false )]
        public virtual ushort Y { get; set; }
        [Parameter("uint8", "_tile", 3, false )]
        public virtual byte Tile { get; set; }
        [Parameter("uint256", "copperSpent", 4, false )]
        public virtual BigInteger CopperSpent { get; set; }
        [Parameter("address", "_tokenAddress", 5, false )]
        public virtual string TokenAddress { get; set; }
        [Parameter("uint256", "amountOfTokensToSend", 6, false )]
        public virtual BigInteger AmountOfTokensToSend { get; set; }
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

    public partial class SellEventDTO : SellEventDTOBase { }

    [Event("Sell")]
    public class SellEventDTOBase : IEventDTO
    {
        [Parameter("uint16", "_x", 1, false )]
        public virtual ushort X { get; set; }
        [Parameter("uint16", "_y", 2, false )]
        public virtual ushort Y { get; set; }
        [Parameter("uint8", "_tile", 3, false )]
        public virtual byte Tile { get; set; }
        [Parameter("address", "_tokenAddress", 4, false )]
        public virtual string TokenAddress { get; set; }
        [Parameter("uint256", "_amount", 5, false )]
        public virtual BigInteger Amount { get; set; }
        [Parameter("address", "_sender", 6, false )]
        public virtual string Sender { get; set; }
    }

    public partial class TokenTransferEventDTO : TokenTransferEventDTOBase { }

    [Event("TokenTransfer")]
    public class TokenTransferEventDTOBase : IEventDTO
    {
        [Parameter("address", "token", 1, false )]
        public virtual string Token { get; set; }
        [Parameter("address", "sender", 2, false )]
        public virtual string Sender { get; set; }
        [Parameter("uint256", "amount", 3, false )]
        public virtual BigInteger Amount { get; set; }
        [Parameter("bytes", "data", 4, false )]
        public virtual byte[] Data { get; set; }
    }

    public partial class BuyPricesOutputDTO : BuyPricesOutputDTOBase { }

    [FunctionOutput]
    public class BuyPricesOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
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



    public partial class SellPricesOutputDTO : SellPricesOutputDTOBase { }

    [FunctionOutput]
    public class SellPricesOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class TokenBalanceOutputDTO : TokenBalanceOutputDTOBase { }

    [FunctionOutput]
    public class TokenBalanceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }














}
