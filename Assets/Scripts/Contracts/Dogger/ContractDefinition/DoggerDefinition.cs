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

namespace Galleass3D.Contracts.Dogger.ContractDefinition
{


    public partial class DoggerDeployment : DoggerDeploymentBase
    {
        public DoggerDeployment() : base(BYTECODE) { }
        public DoggerDeployment(string byteCode) : base(byteCode) { }
    }

    public class DoggerDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b506040516125a13803806125a18339818101604052602081101561003357600080fd5b810190808051906020019092919050505080336000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055506000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16600073ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a380600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505061014b610251565b6040518060800160405280600061ffff168152602001600061ffff168152602001600060ff168152602001600067ffffffffffffffff16815250905060058190806001815401808255809150509060018203906000526020600020016000909192909190915060008201518160000160006101000a81548161ffff021916908361ffff16021790555060208201518160000160026101000a81548161ffff021916908361ffff16021790555060408201518160000160046101000a81548160ff021916908360ff16021790555060608201518160000160056101000a81548167ffffffffffffffff021916908367ffffffffffffffff160217905550505050505061028e565b6040518060800160405280600061ffff168152602001600061ffff168152602001600060ff168152602001600067ffffffffffffffff1681525090565b6123048061029d6000396000f3fe608060405234801561001057600080fd5b506004361061018e5760003560e01c80638da5cb5b116100de578063a9059cbb11610097578063ddc6a17111610071578063ddc6a171146108dc578063e16c7d9814610942578063e4b50cb8146109b0578063f2fde38b14610a645761018e565b8063a9059cbb14610802578063b0619e8514610850578063ba86943e146108b65761018e565b80638da5cb5b146106215780638e1a55fc1461066b5780638f32d59b1461068957806395d89b41146106ab5780639e281a981461072e578063a8bd9c32146107945761018e565b80632e1a7d4d1161014b57806370a082311161012557806370a08231146104b8578063715018a6146105105780637a2a39311461051a5780638462151c146105885761018e565b80632e1a7d4d146103a85780633319bf1a146103ee5780636352211e1461044a5761018e565b806306fdde0314610193578063095ea7b31461021657806318160ddd146102645780631d36e06c1461028257806323b872dd146102f05780632ce643f21461035e575b600080fd5b61019b610aa8565b6040518080602001828103825283818151815260200191508051906020019080838360005b838110156101db5780820151818401526020810190506101c0565b50505050905090810190601f1680156102085780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b6102626004803603604081101561022c57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610ae1565b005b61026c610ba1565b6040518082815260200191505060405180910390f35b6102ae6004803603602081101561029857600080fd5b8101908080359060200190929190505050610bb1565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b61035c6004803603606081101561030657600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610be4565b005b610366610c8d565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6103d4600480360360208110156103be57600080fd5b8101908080359060200190929190505050610cb3565b604051808215151515815260200191505060405180910390f35b6104306004803603602081101561040457600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610e00565b604051808215151515815260200191505060405180910390f35b6104766004803603602081101561046057600080fd5b8101908080359060200190929190505050610ea6565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6104fa600480360360208110156104ce57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610f1d565b6040518082815260200191505060405180910390f35b610518610f66565b005b6105866004803603606081101561053057600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050611036565b005b6105ca6004803603602081101561059e57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050611286565b6040518080602001828103825283818151815260200191508051906020019060200280838360005b8381101561060d5780820151818401526020810190506105f2565b505050509050019250505060405180910390f35b6106296113ce565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6106736113f7565b6040518082815260200191505060405180910390f35b61069161162a565b604051808215151515815260200191505060405180910390f35b6106b3611681565b6040518080602001828103825283818151815260200191508051906020019080838360005b838110156106f35780820151818401526020810190506106d8565b50505050905090810190601f1680156107205780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b61077a6004803603604081101561074457600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803590602001909291905050506116ba565b604051808215151515815260200191505060405180910390f35b6107c0600480360360208110156107aa57600080fd5b810190808035906020019092919050505061186b565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b61084e6004803603604081101561081857600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291908035906020019092919050505061189e565b005b61089c6004803603604081101561086657600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050611933565b604051808215151515815260200191505060405180910390f35b6108be611a24565b604051808261ffff1661ffff16815260200191505060405180910390f35b610928600480360360408110156108f257600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050611a29565b604051808215151515815260200191505060405180910390f35b61096e6004803603602081101561095857600080fd5b8101908080359060200190929190505050611a3d565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6109dc600480360360208110156109c657600080fd5b8101908080359060200190929190505050611af9565b604051808673ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018561ffff1661ffff1681526020018461ffff1661ffff1681526020018360ff1660ff1681526020018267ffffffffffffffff1667ffffffffffffffff1681526020019550505050505060405180910390f35b610aa660048036036020811015610a7a57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050611bf1565b005b6040518060400160405280600f81526020017f47616c6c6561737320446f67676572000000000000000000000000000000000081525081565b610aeb3382611c0e565b610af457600080fd5b610afe8183611c7a565b7fb497174632623317507c114082fd64c660b4313b9375d4c99fd6d9f5067079db338383604051808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001828152602001935050505060405180910390a15050565b6000600160058054905003905090565b60026020528060005260406000206000915054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff161415610c1e57600080fd5b3073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff161415610c5757600080fd5b610c613382611cd0565b610c6a57600080fd5b610c748382611c0e565b610c7d57600080fd5b610c88838383611d3c565b505050565b600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b6000610cbd61162a565b610cc657600080fd5b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905060016003811115610cfa57fe5b8173ffffffffffffffffffffffffffffffffffffffff1663b0e315816040518163ffffffff1660e01b815260040160206040518083038186803b158015610d4057600080fd5b505afa158015610d54573d6000803e3d6000fd5b505050506040513d6020811015610d6a57600080fd5b81019080805190602001909291905050506003811115610d8657fe5b14610d9057600080fd5b823073ffffffffffffffffffffffffffffffffffffffff16311015610db457600080fd5b610dbc6113ce565b73ffffffffffffffffffffffffffffffffffffffff166108fc849081150290604051600060405180830381858888f19350505050610df657fe5b6001915050919050565b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614610e5c57600080fd5b81600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555060019050919050565b60006002600083815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff169050600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff161415610f1857600080fd5b919050565b6000600360008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020549050919050565b610f6e61162a565b610f7757600080fd5b600073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a360008060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550565b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff1614156110d9576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260108152602001807f746f206d757374206e6f7420626520300000000000000000000000000000000081525060200191505060405180910390fd5b3073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff16141561115e576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040180806020018281038252603181526020018061229f6031913960400191505060405180910390fd5b6111688382611c0e565b6111da576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260188152602001807f66726f6d206d757374206f776e2074686520646f67676572000000000000000081525060200191505060405180910390fd5b611204337f7472616e73666572446f67676572000000000000000000000000000000000000611933565b611276576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260148152602001807f7265717569726573207065726d697373696f6e2e00000000000000000000000081525060200191505060405180910390fd5b611281838383611d3c565b505050565b6060600061129383610f1d565b905060008114156112d75760006040519080825280602002602001820160405280156112ce5781602001602082028038833980820191505090505b509150506113c9565b6060816040519080825280602002602001820160405280156113085781602001602082028038833980820191505090505b5090506000611315610ba1565b905060008090506000600190505b8281116113c0578673ffffffffffffffffffffffffffffffffffffffff166002600083815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1614156113b3578084838151811061139e57fe5b60200260200101818152505081806001019250505b8080600101915050611323565b83955050505050505b919050565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905090565b60007f446f6767657200000000000000000000000000000000000000000000000000006000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98836040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b15801561149257600080fd5b505afa1580156114a6573d6000803e3d6000fd5b505050506040513d60208110156114bc57600080fd5b810190808051906020019092919050505073ffffffffffffffffffffffffffffffffffffffff163073ffffffffffffffffffffffffffffffffffffffff161461150457600080fd5b61152e337f6275696c64446f67676572000000000000000000000000000000000000000000611933565b61153757600080fd5b611567337f54696d6265720000000000000000000000000000000000000000000000000000600261ffff16611f3c565b61157057600080fd5b600060019050600061020090506000600190507f85243c881d389c1aacb9e09cc483800240118794218224ef60403c5f092c73ad33848484604051808573ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018461ffff1661ffff1681526020018361ffff1661ffff1681526020018260ff1660ff16815260200194505050505060405180910390a161162033848484612045565b9550505050505090565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614905090565b6040518060400160405280600881526020017f475f444f4747455200000000000000000000000000000000000000000000000081525081565b60006116c461162a565b6116cd57600080fd5b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690506001600381111561170157fe5b8173ffffffffffffffffffffffffffffffffffffffff1663b0e315816040518163ffffffff1660e01b815260040160206040518083038186803b15801561174757600080fd5b505afa15801561175b573d6000803e3d6000fd5b505050506040513d602081101561177157600080fd5b8101908080519060200190929190505050600381111561178d57fe5b1461179757600080fd5b60008490508073ffffffffffffffffffffffffffffffffffffffff1663a9059cbb33866040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200182815260200192505050602060405180830381600087803b15801561182357600080fd5b505af1158015611837573d6000803e3d6000fd5b505050506040513d602081101561184d57600080fd5b81019080805190602001909291905050505060019250505092915050565b60046020528060005260406000206000915054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff1614156118d857600080fd5b3073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff16141561191157600080fd5b61191b3382611c0e565b61192457600080fd5b61192f338383611d3c565b5050565b600080600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663b0619e8585856040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018281526020019250505060206040518083038186803b1580156119e057600080fd5b505afa1580156119f4573d6000803e3d6000fd5b505050506040513d6020811015611a0a57600080fd5b810190808051906020019092919050505091505092915050565b600281565b6000611a358383611cd0565b905092915050565b600080600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98846040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b158015611ab657600080fd5b505afa158015611aca573d6000803e3d6000fd5b505050506040513d6020811015611ae057600080fd5b8101908080519060200190929190505050915050919050565b60008060008060006002600087815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1660058781548110611b4257fe5b9060005260206000200160000160009054906101000a900461ffff1660058881548110611b6b57fe5b9060005260206000200160000160029054906101000a900461ffff1660058981548110611b9457fe5b9060005260206000200160000160049054906101000a900460ff1660058a81548110611bbc57fe5b9060005260206000200160000160059054906101000a900467ffffffffffffffff169450945094509450945091939590929450565b611bf961162a565b611c0257600080fd5b611c0b81612169565b50565b60008273ffffffffffffffffffffffffffffffffffffffff166002600084815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1614905092915050565b806004600084815260200190815260200160002060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505050565b60008273ffffffffffffffffffffffffffffffffffffffff166004600084815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1614905092915050565b600360008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008154809291906001019190505550816002600083815260200190815260200160002060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550600073ffffffffffffffffffffffffffffffffffffffff168373ffffffffffffffffffffffffffffffffffffffff1614611e9857600360008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008154809291906001900391905055506004600082815260200190815260200160002060006101000a81549073ffffffffffffffffffffffffffffffffffffffff02191690555b7ffd19e66d1a4315847e95661bab80aff36f6801c5b2eeeca82491034bd7660abe838383604051808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001828152602001935050505060405180910390a1505050565b6000611f4783611a3d565b73ffffffffffffffffffffffffffffffffffffffff166323b872dd8530856040518463ffffffff1660e01b8152600401808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018281526020019350505050602060405180830381600087803b15801561200157600080fd5b505af1158015612015573d6000803e3d6000fd5b505050506040513d602081101561202b57600080fd5b810190808051906020019092919050505090509392505050565b600061204f612261565b60405180608001604052808661ffff1681526020018561ffff1681526020018460ff1681526020014267ffffffffffffffff1681525090506000600160058390806001815401808255809150509060018203906000526020600020016000909192909190915060008201518160000160006101000a81548161ffff021916908361ffff16021790555060208201518160000160026101000a81548161ffff021916908361ffff16021790555060408201518160000160046101000a81548160ff021916908360ff16021790555060608201518160000160056101000a81548167ffffffffffffffff021916908367ffffffffffffffff160217905550505003905061215c60008883611d3c565b8092505050949350505050565b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff1614156121a357600080fd5b8073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a3806000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555050565b6040518060800160405280600061ffff168152602001600061ffff168152602001600060ff168152602001600067ffffffffffffffff168152509056fe746f206d757374206e6f74206265207468652061646472657373206f662074686520446f6767657220436f6e7472616374a265627a7a72315820d4ed047e41229d28806f0c4b2268e0327a6dab4467b658b992cb31d5800a4c7e64736f6c634300050d0032";
        public DoggerDeploymentBase() : base(BYTECODE) { }
        public DoggerDeploymentBase(string byteCode) : base(byteCode) { }
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
        [Parameter("uint64", "birth", 5)]
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
