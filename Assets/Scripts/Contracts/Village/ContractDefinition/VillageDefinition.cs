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

namespace Galleass3D.Contracts.Village.ContractDefinition
{


    public partial class VillageDeployment : VillageDeploymentBase
    {
        public VillageDeployment() : base(BYTECODE) { }
        public VillageDeployment(string byteCode) : base(byteCode) { }
    }

    public class VillageDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b506040516114d33803806114d38339818101604052602081101561003357600080fd5b81019080805190602001909291905050508080336000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055506000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16600073ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a380600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555050505061137e806101556000396000f3fe608060405234801561001057600080fd5b50600436106100e95760003560e01c806396af3d8a1161008c578063cc549a8d11610066578063cc549a8d1461041c578063dd63133a146104a9578063e16c7d9814610538578063f2fde38b146105a6576100e9565b806396af3d8a146102cf5780639e281a9814610350578063b0619e85146103b6576100e9565b80633319bf1a116100c85780633319bf1a146101fd578063715018a6146102595780638da5cb5b146102635780638f32d59b146102ad576100e9565b80622a2133146100ee5780632ce643f21461016d5780632e1a7d4d146101b7575b600080fd5b610157600480360360c081101561010457600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff1690602001909291908035906020019092919080359060200190929190803590602001909291905050506105ea565b6040518082815260200191505060405180910390f35b6101756107bc565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6101e3600480360360208110156101cd57600080fd5b81019080803590602001909291905050506107e2565b604051808215151515815260200191505060405180910390f35b61023f6004803603602081101561021357600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919050505061092f565b604051808215151515815260200191505060405180910390f35b6102616109d5565b005b61026b610aa5565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6102b5610ace565b604051808215151515815260200191505060405180910390f35b61033a600480360360808110156102e557600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610b25565b6040518082815260200191505060405180910390f35b61039c6004803603604081101561036657600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610b64565b604051808215151515815260200191505060405180910390f35b610402600480360360408110156103cc57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610d15565b604051808215151515815260200191505060405180910390f35b6104676004803603606081101561043257600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff169060200190929190505050610e06565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b61051e600480360360a08110156104bf57600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610e55565b604051808215151515815260200191505060405180910390f35b6105646004803603602081101561054e57600080fd5b810190808035906020019092919050505061103d565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6105e8600480360360208110156105bc57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291905050506110f9565b005b60007f56696c6c616765000000000000000000000000000000000000000000000000006000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98836040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b15801561068557600080fd5b505afa158015610699573d6000803e3d6000fd5b505050506040513d60208110156106af57600080fd5b810190808051906020019092919050505073ffffffffffffffffffffffffffffffffffffffff163073ffffffffffffffffffffffffffffffffffffffff16146106f757600080fd5b888888600260008461ffff1661ffff16815260200190815260200160002060008361ffff1661ffff16815260200190815260200160002060008260ff1660ff16815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff161461079d57600080fd5b6107ab8c8c8c8c8c8c611116565b955050505050509695505050505050565b600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b60006107ec610ace565b6107f557600080fd5b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690506001600381111561082957fe5b8173ffffffffffffffffffffffffffffffffffffffff1663b0e315816040518163ffffffff1660e01b815260040160206040518083038186803b15801561086f57600080fd5b505afa158015610883573d6000803e3d6000fd5b505050506040513d602081101561089957600080fd5b810190808051906020019092919050505060038111156108b557fe5b146108bf57600080fd5b823073ffffffffffffffffffffffffffffffffffffffff163110156108e357600080fd5b6108eb610aa5565b73ffffffffffffffffffffffffffffffffffffffff166108fc849081150290604051600060405180830381858888f1935050505061092557fe5b6001915050919050565b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff161461098b57600080fd5b81600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555060019050919050565b6109dd610ace565b6109e657600080fd5b600073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a360008060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905090565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614905090565b60036020528360005260406000206020528260005260406000206020528160005260406000206020528060005260406000206000935093505050505481565b6000610b6e610ace565b610b7757600080fd5b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905060016003811115610bab57fe5b8173ffffffffffffffffffffffffffffffffffffffff1663b0e315816040518163ffffffff1660e01b815260040160206040518083038186803b158015610bf157600080fd5b505afa158015610c05573d6000803e3d6000fd5b505050506040513d6020811015610c1b57600080fd5b81019080805190602001909291905050506003811115610c3757fe5b14610c4157600080fd5b60008490508073ffffffffffffffffffffffffffffffffffffffff1663a9059cbb33866040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200182815260200192505050602060405180830381600087803b158015610ccd57600080fd5b505af1158015610ce1573d6000803e3d6000fd5b505050506040513d6020811015610cf757600080fd5b81019080805190602001909291905050505060019250505092915050565b600080600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663b0619e8585856040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018281526020019250505060206040518083038186803b158015610dc257600080fd5b505afa158015610dd6573d6000803e3d6000fd5b505050506040513d6020811015610dec57600080fd5b810190808051906020019092919050505091505092915050565b6002602052826000526040600020602052816000526040600020602052806000526040600020600092509250509054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b6000610e807f4c616e640000000000000000000000000000000000000000000000000000000061103d565b73ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff161480610f0c5750610edd7f4c616e644c69620000000000000000000000000000000000000000000000000061103d565b73ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16145b610f1557600080fd5b82600260008861ffff1661ffff16815260200190815260200160002060008761ffff1661ffff16815260200190815260200160002060008660ff1660ff16815260200190815260200160002060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055507f9ddbaf061101ada1338c64912dabc002f73b61a5652827b26a01864e55db68b286868686604051808561ffff1661ffff1681526020018461ffff1661ffff1681526020018360ff1660ff1681526020018273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200194505050505060405180910390a16001905095945050505050565b600080600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98846040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b1580156110b657600080fd5b505afa1580156110ca573d6000803e3d6000fd5b505050506040513d60208110156110e057600080fd5b8101908080519060200190929190505050915050919050565b611101610ace565b61110a57600080fd5b61111381611251565b50565b6000806111427f436974697a656e734c696200000000000000000000000000000000000000000061103d565b90508073ffffffffffffffffffffffffffffffffffffffff1663571b3d52338a8a8a8a8a8a6040518863ffffffff1660e01b8152600401808873ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018761ffff1661ffff1681526020018661ffff1661ffff1681526020018560ff1660ff168152602001848152602001838152602001828152602001975050505050505050602060405180830381600087803b15801561120957600080fd5b505af115801561121d573d6000803e3d6000fd5b505050506040513d602081101561123357600080fd5b81019080805190602001909291905050509150509695505050505050565b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff16141561128b57600080fd5b8073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a3806000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505056fea265627a7a72315820048fcff0f2530b2f65b51800f3c14ad8afda10ca30563a6222640e04958a9c5c64736f6c634300050d0032";
        public VillageDeploymentBase() : base(BYTECODE) { }
        public VillageDeploymentBase(string byteCode) : base(byteCode) { }
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

    public partial class CreateCitizenFunction : CreateCitizenFunctionBase { }

    [Function("createCitizen", "uint256")]
    public class CreateCitizenFunctionBase : FunctionMessage
    {
        [Parameter("uint16", "_x", 1)]
        public virtual ushort X { get; set; }
        [Parameter("uint16", "_y", 2)]
        public virtual ushort Y { get; set; }
        [Parameter("uint8", "_tile", 3)]
        public virtual byte Tile { get; set; }
        [Parameter("bytes32", "food1", 4)]
        public virtual byte[] Food1 { get; set; }
        [Parameter("bytes32", "food2", 5)]
        public virtual byte[] Food2 { get; set; }
        [Parameter("bytes32", "food3", 6)]
        public virtual byte[] Food3 { get; set; }
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



    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }



    public partial class TokenBalanceOutputDTO : TokenBalanceOutputDTOBase { }

    [FunctionOutput]
    public class TokenBalanceOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }










}
