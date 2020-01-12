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

namespace Galleass3D.Contracts.Fishmonger.ContractDefinition
{


    public partial class FishmongerDeployment : FishmongerDeploymentBase
    {
        public FishmongerDeployment() : base(BYTECODE) { }
        public FishmongerDeployment(string byteCode) : base(byteCode) { }
    }

    public class FishmongerDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b5060405161301a38038061301a8339818101604052602081101561003357600080fd5b81019080805190602001909291905050508080336000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055506000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16600073ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a380600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550505050612ec5806101556000396000f3fe608060405234801561001057600080fd5b506004361061012c5760003560e01c806396af3d8a116100ad578063b0619e8511610071578063b0619e851461070a578063cc549a8d14610770578063dd63133a146107fd578063e16c7d981461088c578063f2fde38b146108fa5761012c565b806396af3d8a14610436578063984ffe57146104b75780639e281a9814610538578063a4c0ed361461059e578063ae50d6601461069b5761012c565b806364c33c33116100f457806364c33c331461030d578063715018a61461039c578063772c4ac6146103a65780638da5cb5b146103ca5780638f32d59b146104145761012c565b806306e00623146101315780632ce643f2146101925780632e1a7d4d146101dc5780633319bf1a1461022257806363cf6ffa1461027e575b600080fd5b61017c6004803603606081101561014757600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff16906020019092919050505061093e565b6040518082815260200191505060405180910390f35b61019a610970565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b610208600480360360208110156101f257600080fd5b8101908080359060200190929190505050610996565b604051808215151515815260200191505060405180910390f35b6102646004803603602081101561023857600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610ae3565b604051808215151515815260200191505060405180910390f35b6102f3600480360360a081101561029457600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610b89565b604051808215151515815260200191505060405180910390f35b610382600480360360a081101561032357600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff1690602001909291908035906020019092919050505061106a565b604051808215151515815260200191505060405180910390f35b6103a46112ef565b005b6103ae6113bf565b604051808260ff1660ff16815260200191505060405180910390f35b6103d26113c4565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b61041c6113ed565b604051808215151515815260200191505060405180910390f35b6104a16004803603608081101561044c57600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050611444565b6040518082815260200191505060405180910390f35b610522600480360360808110156104cd57600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050611483565b6040518082815260200191505060405180910390f35b6105846004803603604081101561054e57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803590602001909291905050506114c2565b604051808215151515815260200191505060405180910390f35b610681600480360360608110156105b457600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190803590602001906401000000008111156105fb57600080fd5b82018360208201111561060d57600080fd5b8035906020019184600183028401116401000000008311171561062f57600080fd5b91908080601f016020809104026020016040519081016040528093929190818152602001838380828437600081840152601f19601f820116905080830192505050505050509192919290505050611673565b604051808215151515815260200191505060405180910390f35b6106f0600480360360808110156106b157600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff16906020019092919080359060200190929190505050611973565b604051808215151515815260200191505060405180910390f35b6107566004803603604081101561072057600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050611b83565b604051808215151515815260200191505060405180910390f35b6107bb6004803603606081101561078657600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff169060200190929190505050611c74565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b610872600480360360a081101561081357600080fd5b81019080803561ffff169060200190929190803561ffff169060200190929190803560ff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050611cc3565b604051808215151515815260200191505060405180910390f35b6108b8600480360360208110156108a257600080fd5b8101908080359060200190929190505050611d39565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b61093c6004803603602081101561091057600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050611df5565b005b600560205282600052604060002060205281600052604060002060205280600052604060002060009250925050505481565b600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b60006109a06113ed565b6109a957600080fd5b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff169050600160038111156109dd57fe5b8173ffffffffffffffffffffffffffffffffffffffff1663b0e315816040518163ffffffff1660e01b815260040160206040518083038186803b158015610a2357600080fd5b505afa158015610a37573d6000803e3d6000fd5b505050506040513d6020811015610a4d57600080fd5b81019080805190602001909291905050506003811115610a6957fe5b14610a7357600080fd5b823073ffffffffffffffffffffffffffffffffffffffff16311015610a9757600080fd5b610a9f6113c4565b73ffffffffffffffffffffffffffffffffffffffff166108fc849081150290604051600060405180830381858888f19350505050610ad957fe5b6001915050919050565b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614610b3f57600080fd5b81600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555060019050919050565b60007f466973686d6f6e676572000000000000000000000000000000000000000000006000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98836040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b158015610c2457600080fd5b505afa158015610c38573d6000803e3d6000fd5b505050506040513d6020811015610c4e57600080fd5b810190808051906020019092919050505073ffffffffffffffffffffffffffffffffffffffff163073ffffffffffffffffffffffffffffffffffffffff1614610c9657600080fd5b600073ffffffffffffffffffffffffffffffffffffffff168573ffffffffffffffffffffffffffffffffffffffff161415610cd057600080fd5b6000610cde89898989611e12565b905060008111610ced57600080fd5b60008511610cfa57600080fd5b60008690508073ffffffffffffffffffffffffffffffffffffffff166323b872dd3330896040518463ffffffff1660e01b8152600401808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018281526020019350505050602060405180830381600087803b158015610dba57600080fd5b505af1158015610dce573d6000803e3d6000fd5b505050506040513d6020811015610de457600080fd5b8101908080519060200190929190505050610dfe57600080fd5b610e0b818b8b8a8a611ea7565b6000610e367f46696c6c65740000000000000000000000000000000000000000000000000000611d39565b90508073ffffffffffffffffffffffffffffffffffffffff166340c10f1930600460ff168a026040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200182815260200192505050602060405180830381600087803b158015610ec557600080fd5b505af1158015610ed9573d6000803e3d6000fd5b505050506040513d6020811015610eef57600080fd5b8101908080519060200190929190505050610f0957600080fd5b610f3e8b8b8b610f387f46696c6c65740000000000000000000000000000000000000000000000000000611d39565b8b612098565b6000610f697f436f707065720000000000000000000000000000000000000000000000000000611d39565b9050610f7a8c8c8c848c8902612233565b60008190508073ffffffffffffffffffffffffffffffffffffffff1663a9059cbb338b88026040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200182815260200192505050602060405180830381600087803b15801561100857600080fd5b505af115801561101c573d6000803e3d6000fd5b505050506040513d602081101561103257600080fd5b810190808051906020019092919050505061104c57600080fd5b611055336123b1565b50600197505050505050505095945050505050565b60007f466973686d6f6e676572000000000000000000000000000000000000000000006000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98836040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b15801561110557600080fd5b505afa158015611119573d6000803e3d6000fd5b505050506040513d602081101561112f57600080fd5b810190808051906020019092919050505073ffffffffffffffffffffffffffffffffffffffff163073ffffffffffffffffffffffffffffffffffffffff161461117757600080fd5b878787600260008461ffff1661ffff16815260200190815260200160002060008361ffff1661ffff16815260200190815260200160002060008260ff1660ff16815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff161461121d57600080fd5b600073ffffffffffffffffffffffffffffffffffffffff168873ffffffffffffffffffffffffffffffffffffffff16141561125457fe5b86600460008d61ffff1661ffff16815260200190815260200160002060008c61ffff1661ffff16815260200190815260200160002060008b60ff1660ff16815260200190815260200160002060008a73ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002081905550505050505095945050505050565b6112f76113ed565b61130057600080fd5b600073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a360008060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550565b600481565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905090565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614905090565b60036020528360005260406000206020528260005260406000206020528160005260406000206020528060005260406000206000935093505050505481565b60046020528360005260406000206020528260005260406000206020528160005260406000206020528060005260406000206000935093505050505481565b60006114cc6113ed565b6114d557600080fd5b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690506001600381111561150957fe5b8173ffffffffffffffffffffffffffffffffffffffff1663b0e315816040518163ffffffff1660e01b815260040160206040518083038186803b15801561154f57600080fd5b505afa158015611563573d6000803e3d6000fd5b505050506040513d602081101561157957600080fd5b8101908080519060200190929190505050600381111561159557fe5b1461159f57600080fd5b60008490508073ffffffffffffffffffffffffffffffffffffffff1663a9059cbb33866040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200182815260200192505050602060405180830381600087803b15801561162b57600080fd5b505af115801561163f573d6000803e3d6000fd5b505050506040513d602081101561165557600080fd5b81019080805190602001909291905050505060019250505092915050565b60007f466973686d6f6e676572000000000000000000000000000000000000000000006000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98836040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b15801561170e57600080fd5b505afa158015611722573d6000803e3d6000fd5b505050506040513d602081101561173857600080fd5b810190808051906020019092919050505073ffffffffffffffffffffffffffffffffffffffff163073ffffffffffffffffffffffffffffffffffffffff161461178057600080fd5b7f96bd57d3c3174096a8d69b378ddbbc106adbfcb63971c045e64b183faec8065033878787604051808573ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200183815260200180602001828103825283818151815260200191508051906020019080838360005b8381101561184f578082015181840152602081019050611834565b50505050905090810190601f16801561187c5780820380516001836020036101000a031916815260200191505b509550505050505060405180910390a160008460008151811061189b57fe5b602001015160f81c60f81b60f81c905060008160ff1614156118ca576118c28787876124fa565b93505061196a565b60018160ff1614156118e9576118e187878761253d565b93505061196a565b60028160ff1614156118fa57611968565b6040517f08c379a000000000000000000000000000000000000000000000000000000000815260040180806020018281038252600e8152602001807f756e6b6e6f776e20616374696f6e00000000000000000000000000000000000081525060200191505060405180910390fd5b505b50509392505050565b60007f466973686d6f6e676572000000000000000000000000000000000000000000006000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98836040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b158015611a0e57600080fd5b505afa158015611a22573d6000803e3d6000fd5b505050506040513d6020811015611a3857600080fd5b810190808051906020019092919050505073ffffffffffffffffffffffffffffffffffffffff163073ffffffffffffffffffffffffffffffffffffffff1614611a8057600080fd5b868686600260008461ffff1661ffff16815260200190815260200160002060008361ffff1661ffff16815260200190815260200160002060008260ff1660ff16815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614611b2657600080fd5b86600560008c61ffff1661ffff16815260200190815260200160002060008b61ffff1661ffff16815260200190815260200160002060008a60ff1660ff168152602001908152602001600020819055505050505050949350505050565b600080600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663b0619e8585856040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018281526020019250505060206040518083038186803b158015611c3057600080fd5b505afa158015611c44573d6000803e3d6000fd5b505050506040513d6020811015611c5a57600080fd5b810190808051906020019092919050505091505092915050565b6002602052826000526040600020602052816000526040600020602052806000526040600020600092509250509054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b6000611cd286868686866129f2565b611cdb57600080fd5b6003600560008861ffff1661ffff16815260200190815260200160002060008761ffff1661ffff16815260200190815260200160002060008660ff1660ff168152602001908152602001600020819055506001905095945050505050565b600080600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98846040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b158015611db257600080fd5b505afa158015611dc6573d6000803e3d6000fd5b505050506040513d6020811015611ddc57600080fd5b8101908080519060200190929190505050915050919050565b611dfd6113ed565b611e0657600080fd5b611e0f81612bda565b50565b6000600460008661ffff1661ffff16815260200190815260200160002060008561ffff1661ffff16815260200190815260200160002060008460ff1660ff16815260200190815260200160002060008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020549050949350505050565b6000611ed27f4261790000000000000000000000000000000000000000000000000000000000611d39565b905060008190508673ffffffffffffffffffffffffffffffffffffffff1663095ea7b383856040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200182815260200192505050602060405180830381600087803b158015611f6057600080fd5b505af1158015611f74573d6000803e3d6000fd5b505050506040513d6020811015611f8a57600080fd5b8101908080519060200190929190505050611fa457600080fd5b8073ffffffffffffffffffffffffffffffffffffffff1663626c0a45878787876040518563ffffffff1660e01b8152600401808561ffff1661ffff1681526020018461ffff1661ffff1681526020018373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001828152602001945050505050602060405180830381600087803b15801561204b57600080fd5b505af115801561205f573d6000803e3d6000fd5b505050506040513d602081101561207557600080fd5b810190808051906020019092919050505061208f57600080fd5b50505050505050565b80600360008761ffff1661ffff16815260200190815260200160002060008661ffff1661ffff16815260200190815260200160002060008560ff1660ff16815260200190815260200160002060008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020019081526020016000206000828254019250508190555080600360008761ffff1661ffff16815260200190815260200160002060008661ffff1661ffff16815260200190815260200160002060008560ff1660ff16815260200190815260200160002060008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054101561222c576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260098152602001807f4f766572666c6f773f000000000000000000000000000000000000000000000081525060200191505060405180910390fd5b5050505050565b80600360008761ffff1661ffff16815260200190815260200160002060008661ffff1661ffff16815260200190815260200160002060008560ff1660ff16815260200190815260200160002060008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020541015612314576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040180806020018281038252602c815260200180612e65602c913960400191505060405180910390fd5b80600360008761ffff1661ffff16815260200190815260200160002060008661ffff1661ffff16815260200190815260200160002060008560ff1660ff16815260200190815260200160002060008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020600082825403925050819055505050505050565b6000806123dd7f457870657269656e636500000000000000000000000000000000000000000000611d39565b9050600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff16141561241957600080fd5b60008190508073ffffffffffffffffffffffffffffffffffffffff16632d57830485600360016040518463ffffffff1660e01b8152600401808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018361ffff168152602001821515151581526020019350505050602060405180830381600087803b1580156124b757600080fd5b505af11580156124cb573d6000803e3d6000fd5b505050506040513d60208110156124e157600080fd5b8101908080519060200190929190505050505050919050565b60008061250683612cd2565b9050600061251384612d89565b9050600061252085612e40565b905061252f838383338a612098565b600193505050509392505050565b60008061254983612cd2565b9050600061255684612d89565b9050600061256385612e40565b905061258e7f436f707065720000000000000000000000000000000000000000000000000000611d39565b73ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff161461262e576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040180806020018281038252601a8152602001807f526571756972657320636f707065722069732073656e7420696e00000000000081525060200191505060405180910390fd5b60006126597f46696c6c65740000000000000000000000000000000000000000000000000000611d39565b9050600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff1614156126fe576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260188152602001807f46696c6c6574206d75737420686176652061646472657373000000000000000081525060200191505060405180910390fd5b6000600560008661ffff1661ffff16815260200190815260200160002060008561ffff1661ffff16815260200190815260200160002060008460ff1660ff16815260200190815260200160002054116127bf576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260188152602001807f46696c6c6574206d75737420686176652061207072696365000000000000000081525060200191505060405180910390fd5b6000600560008661ffff1661ffff16815260200190815260200160002060008561ffff1661ffff16815260200190815260200160002060008460ff1660ff16815260200190815260200160002054888161281557fe5b0490506000811161288e576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260138152602001807f416d6f756e742077617320746f6f206c6f773f0000000000000000000000000081525060200191505060405180910390fd5b61289b8585858585612233565b6128a8858585338c612098565b60008290508073ffffffffffffffffffffffffffffffffffffffff1663a9059cbb8b846040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200182815260200192505050602060405180830381600087803b15801561293457600080fd5b505af1158015612948573d6000803e3d6000fd5b505050506040513d602081101561295e57600080fd5b81019080805190602001909291905050506129e1576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040180806020018281038252601a8152602001807f4661696c656420746f207472616e736665722066696c6c65747300000000000081525060200191505060405180910390fd5b600196505050505050509392505050565b6000612a1d7f4c616e6400000000000000000000000000000000000000000000000000000000611d39565b73ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff161480612aa95750612a7a7f4c616e644c696200000000000000000000000000000000000000000000000000611d39565b73ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16145b612ab257600080fd5b82600260008861ffff1661ffff16815260200190815260200160002060008761ffff1661ffff16815260200190815260200160002060008660ff1660ff16815260200190815260200160002060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055507f9ddbaf061101ada1338c64912dabc002f73b61a5652827b26a01864e55db68b286868686604051808561ffff1661ffff1681526020018461ffff1661ffff1681526020018360ff1660ff1681526020018273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200194505050505060405180910390a16001905095945050505050565b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff161415612c1457600080fd5b8073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a3806000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555050565b60008082600181518110612ce257fe5b602001015160f81c60f81b7effffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff19169050600083600281518110612d2057fe5b602001015160f81c60f81b7effffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff191690506008827dffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff1916901b91508060f01c8260f01c0192505050919050565b60008082600381518110612d9957fe5b602001015160f81c60f81b7effffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff19169050600083600481518110612dd757fe5b602001015160f81c60f81b7effffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff191690506008827dffffffffffffffffffffffffffffffffffffffffffffffffffffffffffff1916901b91508060f01c8260f01c0192505050919050565b600081600581518110612e4f57fe5b602001015160f81c60f81b60f81c905091905056fe546869732074696c6520646f6573206e6f74206861766520656e6f756768206f66207468697320746f6b656ea265627a7a7231582054da7d7827fec56253a7b46a276525d0f09d6172dd4ba0d5365140b0e5fa074464736f6c634300050d0032";
        public FishmongerDeploymentBase() : base(BYTECODE) { }
        public FishmongerDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "_galleass", 1)]
        public virtual string Galleass { get; set; }
    }

    public partial class FILLETSPERFISHFunction : FILLETSPERFISHFunctionBase { }

    [Function("FILLETSPERFISH", "uint8")]
    public class FILLETSPERFISHFunctionBase : FunctionMessage
    {

    }

    public partial class FilletPriceFunction : FilletPriceFunctionBase { }

    [Function("filletPrice", "uint256")]
    public class FilletPriceFunctionBase : FunctionMessage
    {
        [Parameter("uint16", "", 1)]
        public virtual ushort ReturnValue1 { get; set; }
        [Parameter("uint16", "", 2)]
        public virtual ushort ReturnValue2 { get; set; }
        [Parameter("uint8", "", 3)]
        public virtual byte ReturnValue3 { get; set; }
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

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class PriceFunction : PriceFunctionBase { }

    [Function("price", "uint256")]
    public class PriceFunctionBase : FunctionMessage
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

    public partial class SetPriceFunction : SetPriceFunctionBase { }

    [Function("setPrice", "bool")]
    public class SetPriceFunctionBase : FunctionMessage
    {
        [Parameter("uint16", "_x", 1)]
        public virtual ushort X { get; set; }
        [Parameter("uint16", "_y", 2)]
        public virtual ushort Y { get; set; }
        [Parameter("uint8", "_tile", 3)]
        public virtual byte Tile { get; set; }
        [Parameter("address", "_species", 4)]
        public virtual string Species { get; set; }
        [Parameter("uint256", "_price", 5)]
        public virtual BigInteger Price { get; set; }
    }

    public partial class SetFilletPriceFunction : SetFilletPriceFunctionBase { }

    [Function("setFilletPrice", "bool")]
    public class SetFilletPriceFunctionBase : FunctionMessage
    {
        [Parameter("uint16", "_x", 1)]
        public virtual ushort X { get; set; }
        [Parameter("uint16", "_y", 2)]
        public virtual ushort Y { get; set; }
        [Parameter("uint8", "_tile", 3)]
        public virtual byte Tile { get; set; }
        [Parameter("uint256", "_price", 4)]
        public virtual BigInteger Price { get; set; }
    }

    public partial class SellFishFunction : SellFishFunctionBase { }

    [Function("sellFish", "bool")]
    public class SellFishFunctionBase : FunctionMessage
    {
        [Parameter("uint16", "_x", 1)]
        public virtual ushort X { get; set; }
        [Parameter("uint16", "_y", 2)]
        public virtual ushort Y { get; set; }
        [Parameter("uint8", "_tile", 3)]
        public virtual byte Tile { get; set; }
        [Parameter("address", "_species", 4)]
        public virtual string Species { get; set; }
        [Parameter("uint256", "_amount", 5)]
        public virtual BigInteger Amount { get; set; }
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

    public partial class FILLETSPERFISHOutputDTO : FILLETSPERFISHOutputDTOBase { }

    [FunctionOutput]
    public class FILLETSPERFISHOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint8", "", 1)]
        public virtual byte ReturnValue1 { get; set; }
    }

    public partial class FilletPriceOutputDTO : FilletPriceOutputDTOBase { }

    [FunctionOutput]
    public class FilletPriceOutputDTOBase : IFunctionOutputDTO 
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

    public partial class PriceOutputDTO : PriceOutputDTOBase { }

    [FunctionOutput]
    public class PriceOutputDTOBase : IFunctionOutputDTO 
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
