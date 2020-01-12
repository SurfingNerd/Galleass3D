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

namespace Galleass3D.Contracts.TimberCamp.ContractDefinition
{


    public partial class TimberCampDeployment : TimberCampDeploymentBase
    {
        public TimberCampDeployment() : base(BYTECODE) { }
        public TimberCampDeployment(string byteCode) : base(byteCode) { }
    }

    public class TimberCampDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x6080604052600160f01b600460006101000a81548161ffff021916908360f01c021790555061066660f01b600460026101000a81548161ffff021916908360f01c021790555060086004806101000a81548160ff021916908360ff1602179055507f54696d626572000000000000000000000000000000000000000000000000000060055534801561009057600080fd5b50604051611a09380380611a09833981810160405260208110156100b357600080fd5b81019080805190602001909291905050508080336000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055506000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16600073ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a380600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550505050611834806101d56000396000f3fe608060405234801561001057600080fd5b506004361061012c5760003560e01c80638f32d59b116100ad578063cc549a8d11610071578063cc549a8d146105c3578063dd63133a14610650578063e16c7d98146106df578063f2fde38b1461074d578063f8897945146107915761012c565b80638f32d59b146103ef57806396af3d8a146104115780639e281a9814610492578063b0619e85146104f8578063b3dee3861461055e5761012c565b80636ac5db19116100f45780636ac5db19146102a2578063715018a614610302578063730879a91461030c57806383c2396c146103815780638da5cb5b146103a55761012c565b806324265000146101315780632ce643f2146101985780632e1a7d4d146101e25780633319bf1a146102285780633a63d88614610284575b600080fd5b61017c6004803603606081101561014757600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff1690602001909291905050506107f1565b604051808260ff1660ff16815260200191505060405180910390f35b6101a0610972565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b61020e600480360360208110156101f857600080fd5b8101908080359060200190929190505050610998565b604051808215151515815260200191505060405180910390f35b61026a6004803603602081101561023e57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610ae5565b604051808215151515815260200191505060405180910390f35b61028c610b8b565b6040518082815260200191505060405180910390f35b6102aa610b91565b60405180827dffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff19167dffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff1916815260200191505060405180910390f35b61030a610ba4565b005b6103576004803603606081101561032257600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff169060200190929190505050610c74565b604051808267ffffffffffffffff1667ffffffffffffffff16815260200191505060405180910390f35b610389610cb7565b604051808260ff1660ff16815260200191505060405180910390f35b6103ad610cc9565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6103f7610cf2565b604051808215151515815260200191505060405180910390f35b61047c6004803603608081101561042757600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610d49565b6040518082815260200191505060405180910390f35b6104de600480360360408110156104a857600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610d88565b604051808215151515815260200191505060405180910390f35b6105446004803603604081101561050e57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610f39565b604051808215151515815260200191505060405180910390f35b6105a96004803603606081101561057457600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff16906020019092919050505061102a565b604051808215151515815260200191505060405180910390f35b61060e600480360360608110156105d957600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff16906020019092919050505061134d565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6106c5600480360360a081101561066657600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff1690602001909291908035906020019092919050505061139c565b604051808215151515815260200191505060405180910390f35b61070b600480360360208110156106f557600080fd5b8101908080359060200190929190505050611433565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b61078f6004803603602081101561076357600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291905050506114ef565b005b61079961150c565b60405180827dffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff19167dffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff1916815260200191505060405180910390f35b60008090506000600460009054906101000a900460f01b60f01c90506000600460029054906101000a900460f01b60f01c905060004361ffff1690505b600660008861ffff1661ffff16815260200190815260200160002060008761ffff1661ffff16815260200190815260200160002060008660ff1660ff16815260200190815260200160002060009054906101000a900467ffffffffffffffff1667ffffffffffffffff168167ffffffffffffffff16106109645760008167ffffffffffffffff164090506000816001602081106108c757fe5b1a60f81b60f81c60ff166008836000602081106108e057fe5b1a60f81b60f81c60ff1661ffff16901b1790508461ffff168161ffff161015801561091357508361ffff168161ffff1611155b156109575785806001019650506004809054906101000a900460ff1660ff168660ff1610610956576004809054906101000a900460ff169550505050505061096b565b5b600183039250505061082e565b8393505050505b9392505050565b600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b60006109a2610cf2565b6109ab57600080fd5b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff169050600160038111156109df57fe5b8173ffffffffffffffffffffffffffffffffffffffff1663b0e315816040518163ffffffff1660e01b815260040160206040518083038186803b158015610a2557600080fd5b505afa158015610a39573d6000803e3d6000fd5b505050506040513d6020811015610a4f57600080fd5b81019080805190602001909291905050506003811115610a6b57fe5b14610a7557600080fd5b823073ffffffffffffffffffffffffffffffffffffffff16311015610a9957600080fd5b610aa1610cc9565b73ffffffffffffffffffffffffffffffffffffffff166108fc849081150290604051600060405180830381858888f19350505050610adb57fe5b6001915050919050565b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614610b4157600080fd5b81600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555060019050919050565b60055481565b600460029054906101000a900460f01b81565b610bac610cf2565b610bb557600080fd5b600073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a360008060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550565b6006602052826000526040600020602052816000526040600020602052806000526040600020600092509250509054906101000a900467ffffffffffffffff1681565b6004809054906101000a900460ff1681565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905090565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614905090565b60036020528360005260406000206020528260005260406000206020528160005260406000206020528060005260406000206000935093505050505481565b6000610d92610cf2565b610d9b57600080fd5b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905060016003811115610dcf57fe5b8173ffffffffffffffffffffffffffffffffffffffff1663b0e315816040518163ffffffff1660e01b815260040160206040518083038186803b158015610e1557600080fd5b505afa158015610e29573d6000803e3d6000fd5b505050506040513d6020811015610e3f57600080fd5b81019080805190602001909291905050506003811115610e5b57fe5b14610e6557600080fd5b60008490508073ffffffffffffffffffffffffffffffffffffffff1663a9059cbb33866040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200182815260200192505050602060405180830381600087803b158015610ef157600080fd5b505af1158015610f05573d6000803e3d6000fd5b505050506040513d6020811015610f1b57600080fd5b81019080805190602001909291905050505060019250505092915050565b600080600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663b0619e8585856040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018281526020019250505060206040518083038186803b158015610fe657600080fd5b505afa158015610ffa573d6000803e3d6000fd5b505050506040513d602081101561101057600080fd5b810190808051906020019092919050505091505092915050565b60007f54696d62657243616d70000000000000000000000000000000000000000000006000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98836040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b1580156110c557600080fd5b505afa1580156110d9573d6000803e3d6000fd5b505050506040513d60208110156110ef57600080fd5b810190808051906020019092919050505073ffffffffffffffffffffffffffffffffffffffff163073ffffffffffffffffffffffffffffffffffffffff161461113757600080fd5b858585600260008461ffff1661ffff16815260200190815260200160002060008361ffff1661ffff16815260200190815260200160002060008260ff1660ff16815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16146111dd57600080fd5b60006111ea8a8a8a6107f1565b905060006111f9600554611433565b90508073ffffffffffffffffffffffffffffffffffffffff166340c10f1933846040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018260ff16815260200192505050602060405180830381600087803b15801561128557600080fd5b505af1158015611299573d6000803e3d6000fd5b505050506040513d60208110156112af57600080fd5b81019080805190602001909291905050506112c957600080fd5b43600660008d61ffff1661ffff16815260200190815260200160002060008c61ffff1661ffff16815260200190815260200160002060008b60ff1660ff16815260200190815260200160002060006101000a81548167ffffffffffffffff021916908367ffffffffffffffff16021790555060019750505050505050509392505050565b6002602052826000526040600020602052816000526040600020602052806000526040600020600092509250509054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b60006113ab868686868661151f565b6113b457600080fd5b43600660008861ffff1661ffff16815260200190815260200160002060008761ffff1661ffff16815260200190815260200160002060008660ff1660ff16815260200190815260200160002060006101000a81548167ffffffffffffffff021916908367ffffffffffffffff1602179055506001905095945050505050565b600080600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98846040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b1580156114ac57600080fd5b505afa1580156114c0573d6000803e3d6000fd5b505050506040513d60208110156114d657600080fd5b8101908080519060200190929190505050915050919050565b6114f7610cf2565b61150057600080fd5b61150981611707565b50565b600460009054906101000a900460f01b81565b600061154a7f4c616e6400000000000000000000000000000000000000000000000000000000611433565b73ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614806115d657506115a77f4c616e644c696200000000000000000000000000000000000000000000000000611433565b73ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16145b6115df57600080fd5b82600260008861ffff1661ffff16815260200190815260200160002060008761ffff1661ffff16815260200190815260200160002060008660ff1660ff16815260200190815260200160002060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055507f9ddbaf061101ada1338c64912dabc002f73b61a5652827b26a01864e55db68b286868686604051808561ffff1661ffff1681526020018461ffff1661ffff1681526020018360ff1660ff1681526020018273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200194505050505060405180910390a16001905095945050505050565b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff16141561174157600080fd5b8073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a3806000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505056fea265627a7a723158204cc70a7dc40531ecd31e46016e30be587c3ac6983097d90bf22db947324e188d64736f6c634300050d0032";
        public TimberCampDeploymentBase() : base(BYTECODE) { }
        public TimberCampDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "_galleass", 1)]
        public virtual string Galleass { get; set; }
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

    public partial class LastBlockFunction : LastBlockFunctionBase { }

    [Function("lastBlock", "uint64")]
    public class LastBlockFunctionBase : FunctionMessage
    {
        [Parameter("uint16", "", 1)]
        public virtual ushort ReturnValue1 { get; set; }
        [Parameter("uint16", "", 2)]
        public virtual ushort ReturnValue2 { get; set; }
        [Parameter("uint8", "", 3)]
        public virtual byte ReturnValue3 { get; set; }
    }

    public partial class MaxFunction : MaxFunctionBase { }

    [Function("max", "bytes2")]
    public class MaxFunctionBase : FunctionMessage
    {

    }

    public partial class MaxCollectFunction : MaxCollectFunctionBase { }

    [Function("maxCollect", "uint8")]
    public class MaxCollectFunctionBase : FunctionMessage
    {

    }

    public partial class MinFunction : MinFunctionBase { }

    [Function("min", "bytes2")]
    public class MinFunctionBase : FunctionMessage
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

    public partial class ResourceFunction : ResourceFunctionBase { }

    [Function("resource", "bytes32")]
    public class ResourceFunctionBase : FunctionMessage
    {

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

    public partial class CollectFunction : CollectFunctionBase { }

    [Function("collect", "bool")]
    public class CollectFunctionBase : FunctionMessage
    {
        [Parameter("uint16", "_x", 1)]
        public virtual ushort X { get; set; }
        [Parameter("uint16", "_y", 2)]
        public virtual ushort Y { get; set; }
        [Parameter("uint8", "_tile", 3)]
        public virtual byte Tile { get; set; }
    }

    public partial class CanCollectFunction : CanCollectFunctionBase { }

    [Function("canCollect", "uint8")]
    public class CanCollectFunctionBase : FunctionMessage
    {
        [Parameter("uint16", "_x", 1)]
        public virtual ushort X { get; set; }
        [Parameter("uint16", "_y", 2)]
        public virtual ushort Y { get; set; }
        [Parameter("uint8", "_tile", 3)]
        public virtual byte Tile { get; set; }
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

    public partial class LastBlockOutputDTO : LastBlockOutputDTOBase { }

    [FunctionOutput]
    public class LastBlockOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint64", "", 1)]
        public virtual ulong ReturnValue1 { get; set; }
    }

    public partial class MaxOutputDTO : MaxOutputDTOBase { }

    [FunctionOutput]
    public class MaxOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes2", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class MaxCollectOutputDTO : MaxCollectOutputDTOBase { }

    [FunctionOutput]
    public class MaxCollectOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint8", "", 1)]
        public virtual byte ReturnValue1 { get; set; }
    }

    public partial class MinOutputDTO : MinOutputDTOBase { }

    [FunctionOutput]
    public class MinOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes2", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class ResourceOutputDTO : ResourceOutputDTOBase { }

    [FunctionOutput]
    public class ResourceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bytes32", "", 1)]
        public virtual byte[] ReturnValue1 { get; set; }
    }

    public partial class TokenBalanceOutputDTO : TokenBalanceOutputDTOBase { }

    [FunctionOutput]
    public class TokenBalanceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }













    public partial class CanCollectOutputDTO : CanCollectOutputDTOBase { }

    [FunctionOutput]
    public class CanCollectOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint8", "amount", 1)]
        public virtual byte Amount { get; set; }
    }
}
