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

namespace Galleass3D.Contracts.Citizens.ContractDefinition
{


    public partial class CitizensDeployment : CitizensDeploymentBase
    {
        public CitizensDeployment() : base(BYTECODE) { }
        public CitizensDeployment(string byteCode) : base(byteCode) { }
    }

    public class CitizensDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x60806040523480156200001157600080fd5b5060405162002e4438038062002e44833981810160405260208110156200003757600080fd5b810190808051906020019092919050505080336000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055506000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16600073ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a380600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505062000151620002bf565b604051806101000160405280600060ff16815260200160008152602001600061ffff168152602001600061ffff168152602001600060ff1681526020016000801b81526020016000801b8152602001600067ffffffffffffffff1681525090506005819080600181540180825580915050906001820390600052602060002090600602016000909192909190915060008201518160000160006101000a81548160ff021916908360ff1602179055506020820151816001015560408201518160020160006101000a81548161ffff021916908361ffff16021790555060608201518160020160026101000a81548161ffff021916908361ffff16021790555060808201518160020160046101000a81548160ff021916908360ff16021790555060a0820151816003015560c0820151816004015560e08201518160050160006101000a81548167ffffffffffffffff021916908367ffffffffffffffff160217905550505050505062000322565b604051806101000160405280600060ff16815260200160008152602001600061ffff168152602001600061ffff168152602001600060ff1681526020016000801916815260200160008019168152602001600067ffffffffffffffff1681525090565b612b1280620003326000396000f3fe608060405234801561001057600080fd5b50600436106101c45760003560e01c80638462151c116100f9578063b0619e8511610097578063ddc6a17111610071578063ddc6a17114610a71578063e16c7d9814610ad7578063e4b50cb814610b45578063f2fde38b14610c1b576101c4565b8063b0619e8514610965578063b9c8dc94146109cb578063d896dd6414610a1e576101c4565b806395d89b41116100d357806395d89b41146107c05780639e281a9814610843578063a8bd9c32146108a9578063a9059cbb14610917576101c4565b80638462151c146106bb5780638da5cb5b146107545780638f32d59b1461079e576101c4565b80633319bf1a116101665780636352211e116101405780636352211e1461057d57806370a08231146105eb578063715018a6146106435780637a2a39311461064d576101c4565b80633319bf1a146104245780634848b1a5146104805780635185bdf6146104d0576101c4565b80631d36e06c116101a25780631d36e06c146102b857806323b872dd146103265780632ce643f2146103945780632e1a7d4d146103de576101c4565b806306fdde03146101c9578063095ea7b31461024c57806318160ddd1461029a575b600080fd5b6101d1610c5f565b6040518080602001828103825283818151815260200191508051906020019080838360005b838110156102115780820151818401526020810190506101f6565b50505050905090810190601f16801561023e5780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b6102986004803603604081101561026257600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610c98565b005b6102a2610d58565b6040518082815260200191505060405180910390f35b6102e4600480360360208110156102ce57600080fd5b8101908080359060200190929190505050610d68565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6103926004803603606081101561033c57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610d9b565b005b61039c610e44565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b61040a600480360360208110156103f457600080fd5b8101908080359060200190929190505050610e6a565b604051808215151515815260200191505060405180910390f35b6104666004803603602081101561043a57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610fb7565b604051808215151515815260200191505060405180910390f35b6104b66004803603604081101561049657600080fd5b81019080803590602001909291908035906020019092919050505061105d565b604051808215151515815260200191505060405180910390f35b61056760048036036101008110156104e757600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803560ff16906020019092919080359060200190929190803561ffff169060200190929190803561ffff169060200190929190803560ff1690602001909291908035906020019092919080359060200190929190505050611326565b6040518082815260200191505060405180910390f35b6105a96004803603602081101561059357600080fd5b81019080803590602001909291905050506114b2565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b61062d6004803603602081101561060157600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050611529565b6040518082815260200191505060405180910390f35b61064b611572565b005b6106b96004803603606081101561066357600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050611642565b005b6106fd600480360360208110156106d157600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919050505061170b565b6040518080602001828103825283818151815260200191508051906020019060200280838360005b83811015610740578082015181840152602081019050610725565b505050509050019250505060405180910390f35b61075c611853565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6107a661187c565b604051808215151515815260200191505060405180910390f35b6107c86118d3565b6040518080602001828103825283818151815260200191508051906020019080838360005b838110156108085780820151818401526020810190506107ed565b50505050905090810190601f1680156108355780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b61088f6004803603604081101561085957600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291908035906020019092919050505061190c565b604051808215151515815260200191505060405180910390f35b6108d5600480360360208110156108bf57600080fd5b8101908080359060200190929190505050611abd565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6109636004803603604081101561092d57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050611af0565b005b6109b16004803603604081101561097b57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050611b85565b604051808215151515815260200191505060405180910390f35b610a04600480360360408110156109e157600080fd5b8101908080359060200190929190803560ff169060200190929190505050611c76565b604051808215151515815260200191505060405180910390f35b610a5760048036036040811015610a3457600080fd5b8101908080359060200190929190803560ff169060200190929190505050611f53565b604051808215151515815260200191505060405180910390f35b610abd60048036036040811015610a8757600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050612230565b604051808215151515815260200191505060405180910390f35b610b0360048036036020811015610aed57600080fd5b8101908080359060200190929190505050612244565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b610b7160048036036020811015610b5b57600080fd5b8101908080359060200190929190505050612300565b604051808a73ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018960ff1660ff1681526020018881526020018761ffff1661ffff1681526020018661ffff1661ffff1681526020018560ff1660ff1681526020018481526020018381526020018267ffffffffffffffff1667ffffffffffffffff168152602001995050505050505050505060405180910390f35b610c5d60048036036020811015610c3157600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291905050506123f2565b005b6040518060400160405280601081526020017f47616c6c6561737320436974697a656e0000000000000000000000000000000081525081565b610ca2338261240f565b610cab57600080fd5b610cb5818361247b565b7fb497174632623317507c114082fd64c660b4313b9375d4c99fd6d9f5067079db338383604051808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001828152602001935050505060405180910390a15050565b6000600160058054905003905090565b60026020528060005260406000206000915054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff161415610dd557600080fd5b3073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff161415610e0e57600080fd5b610e1833826124d1565b610e2157600080fd5b610e2b838261240f565b610e3457600080fd5b610e3f83838361253d565b505050565b600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b6000610e7461187c565b610e7d57600080fd5b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905060016003811115610eb157fe5b8173ffffffffffffffffffffffffffffffffffffffff1663b0e315816040518163ffffffff1660e01b815260040160206040518083038186803b158015610ef757600080fd5b505afa158015610f0b573d6000803e3d6000fd5b505050506040513d6020811015610f2157600080fd5b81019080805190602001909291905050506003811115610f3d57fe5b14610f4757600080fd5b823073ffffffffffffffffffffffffffffffffffffffff16311015610f6b57600080fd5b610f73611853565b73ffffffffffffffffffffffffffffffffffffffff166108fc849081150290604051600060405180830381858888f19350505050610fad57fe5b6001915050919050565b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff161461101357600080fd5b81600160006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555060019050919050565b60007f436974697a656e730000000000000000000000000000000000000000000000006000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98836040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b1580156110f857600080fd5b505afa15801561110c573d6000803e3d6000fd5b505050506040513d602081101561112257600080fd5b810190808051906020019092919050505073ffffffffffffffffffffffffffffffffffffffff163073ffffffffffffffffffffffffffffffffffffffff161461116a57600080fd5b6111937f436974697a656e734c6962000000000000000000000000000000000000000000612244565b73ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16146111ca57600080fd5b6000600586815481106111d957fe5b906000526020600020906006020190508481600101819055508060020160029054906101000a900461ffff1661ffff168160020160009054906101000a900461ffff1661ffff16877f4fadc0f06a1309c767c9e693caee25fac10a24a989613e3428e97ff34e3f3b668460020160049054906101000a900460ff16600260008c815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff168660000160009054906101000a900460ff16876001015488600301548960040154604051808760ff1660ff1681526020018673ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018560ff1660ff168152602001848152602001838152602001828152602001965050505050505060405180910390a46001935050505092915050565b60007f436974697a656e730000000000000000000000000000000000000000000000006000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98836040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b1580156113c157600080fd5b505afa1580156113d5573d6000803e3d6000fd5b505050506040513d60208110156113eb57600080fd5b810190808051906020019092919050505073ffffffffffffffffffffffffffffffffffffffff163073ffffffffffffffffffffffffffffffffffffffff161461143357600080fd5b61145c7f436974697a656e734c6962000000000000000000000000000000000000000000612244565b73ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff161461149357600080fd5b6114a38b8b8b8b8b8b8b8b61273d565b50505098975050505050505050565b60006002600083815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff169050600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff16141561152457600080fd5b919050565b6000600360008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020549050919050565b61157a61187c565b61158357600080fd5b600073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a360008060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550565b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff16141561167c57600080fd5b3073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff1614156116b557600080fd5b6116bf838261240f565b6116c857600080fd5b6116f2337f7472616e73666572436974697a656e7300000000000000000000000000000000611b85565b6116fb57600080fd5b61170683838361253d565b505050565b6060600061171883611529565b9050600081141561175c5760006040519080825280602002602001820160405280156117535781602001602082028038833980820191505090505b5091505061184e565b60608160405190808252806020026020018201604052801561178d5781602001602082028038833980820191505090505b509050600061179a610d58565b905060008090506000600190505b828111611845578673ffffffffffffffffffffffffffffffffffffffff166002600083815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff161415611838578084838151811061182357fe5b60200260200101818152505081806001019250505b80806001019150506117a8565b83955050505050505b919050565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff16905090565b60008060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614905090565b6040518060400160405280600981526020017f475f434954495a454e000000000000000000000000000000000000000000000081525081565b600061191661187c565b61191f57600080fd5b6000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690506001600381111561195357fe5b8173ffffffffffffffffffffffffffffffffffffffff1663b0e315816040518163ffffffff1660e01b815260040160206040518083038186803b15801561199957600080fd5b505afa1580156119ad573d6000803e3d6000fd5b505050506040513d60208110156119c357600080fd5b810190808051906020019092919050505060038111156119df57fe5b146119e957600080fd5b60008490508073ffffffffffffffffffffffffffffffffffffffff1663a9059cbb33866040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200182815260200192505050602060405180830381600087803b158015611a7557600080fd5b505af1158015611a89573d6000803e3d6000fd5b505050506040513d6020811015611a9f57600080fd5b81019080805190602001909291905050505060019250505092915050565b60046020528060005260406000206000915054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff161415611b2a57600080fd5b3073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff161415611b6357600080fd5b611b6d338261240f565b611b7657600080fd5b611b8133838361253d565b5050565b600080600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663b0619e8585856040518363ffffffff1660e01b8152600401808373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018281526020019250505060206040518083038186803b158015611c3257600080fd5b505afa158015611c46573d6000803e3d6000fd5b505050506040513d6020811015611c5c57600080fd5b810190808051906020019092919050505091505092915050565b60007f436974697a656e730000000000000000000000000000000000000000000000006000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98836040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b158015611d1157600080fd5b505afa158015611d25573d6000803e3d6000fd5b505050506040513d6020811015611d3b57600080fd5b810190808051906020019092919050505073ffffffffffffffffffffffffffffffffffffffff163073ffffffffffffffffffffffffffffffffffffffff1614611d8357600080fd5b611dac7f436974697a656e734c6962000000000000000000000000000000000000000000612244565b73ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614611de357600080fd5b600060058681548110611df257fe5b90600052602060002090600602019050848160020160046101000a81548160ff021916908360ff1602179055508060020160029054906101000a900461ffff1661ffff168160020160009054906101000a900461ffff1661ffff16877f4fadc0f06a1309c767c9e693caee25fac10a24a989613e3428e97ff34e3f3b668460020160049054906101000a900460ff16600260008c815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff168660000160009054906101000a900460ff16876001015488600301548960040154604051808760ff1660ff1681526020018673ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018560ff1660ff168152602001848152602001838152602001828152602001965050505050505060405180910390a46001935050505092915050565b60007f436974697a656e730000000000000000000000000000000000000000000000006000600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98836040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b158015611fee57600080fd5b505afa158015612002573d6000803e3d6000fd5b505050506040513d602081101561201857600080fd5b810190808051906020019092919050505073ffffffffffffffffffffffffffffffffffffffff163073ffffffffffffffffffffffffffffffffffffffff161461206057600080fd5b6120897f436974697a656e734c6962000000000000000000000000000000000000000000612244565b73ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16146120c057600080fd5b6000600586815481106120cf57fe5b90600052602060002090600602019050848160000160006101000a81548160ff021916908360ff1602179055508060020160029054906101000a900461ffff1661ffff168160020160009054906101000a900461ffff1661ffff16877f4fadc0f06a1309c767c9e693caee25fac10a24a989613e3428e97ff34e3f3b668460020160049054906101000a900460ff16600260008c815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff168660000160009054906101000a900460ff16876001015488600301548960040154604051808760ff1660ff1681526020018673ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018560ff1660ff168152602001848152602001838152602001828152602001965050505050505060405180910390a46001935050505092915050565b600061223c83836124d1565b905092915050565b600080600160009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1690508073ffffffffffffffffffffffffffffffffffffffff1663e16c7d98846040518263ffffffff1660e01b81526004018082815260200191505060206040518083038186803b1580156122bd57600080fd5b505afa1580156122d1573d6000803e3d6000fd5b505050506040513d60208110156122e757600080fd5b8101908080519060200190929190505050915050919050565b60008060008060008060008060008060058b8154811061231c57fe5b90600052602060002090600602019050600260008c815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff168160000160009054906101000a900460ff1682600101548360020160009054906101000a900461ffff168460020160029054906101000a900461ffff168560020160049054906101000a900460ff16866003015487600401548860050160009054906101000a900467ffffffffffffffff16995099509950995099509950995099509950509193959799909294969850565b6123fa61187c565b61240357600080fd5b61240c81612982565b50565b60008273ffffffffffffffffffffffffffffffffffffffff166002600084815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1614905092915050565b806004600084815260200190815260200160002060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055505050565b60008273ffffffffffffffffffffffffffffffffffffffff166004600084815260200190815260200160002060009054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1614905092915050565b600360008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008154809291906001019190505550816002600083815260200190815260200160002060006101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff160217905550600073ffffffffffffffffffffffffffffffffffffffff168373ffffffffffffffffffffffffffffffffffffffff161461269957600360008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008154809291906001900391905055506004600082815260200190815260200160002060006101000a81549073ffffffffffffffffffffffffffffffffffffffff02191690555b7ffd19e66d1a4315847e95661bab80aff36f6801c5b2eeeca82491034bd7660abe838383604051808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001828152602001935050505060405180910390a1505050565b6000612747612a7a565b6040518061010001604052808a60ff1681526020018981526020018861ffff1681526020018761ffff1681526020018660ff1681526020018581526020018481526020014367ffffffffffffffff168152509050600060016005839080600181540180825580915050906001820390600052602060002090600602016000909192909190915060008201518160000160006101000a81548160ff021916908360ff1602179055506020820151816001015560408201518160020160006101000a81548161ffff021916908361ffff16021790555060608201518160020160026101000a81548161ffff021916908361ffff16021790555060808201518160020160046101000a81548160ff021916908360ff16021790555060a0820151816003015560c0820151816004015560e08201518160050160006101000a81548167ffffffffffffffff021916908367ffffffffffffffff16021790555050500390506128b360008c8361253d565b816060015161ffff16826040015161ffff16827f4fadc0f06a1309c767c9e693caee25fac10a24a989613e3428e97ff34e3f3b6685608001518f876000015188602001518960a001518a60c00151604051808760ff1660ff1681526020018673ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020018560ff1660ff168152602001848152602001838152602001828152602001965050505050505060405180910390a4809250505098975050505050505050565b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff1614156129bc57600080fd5b8073ffffffffffffffffffffffffffffffffffffffff166000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff167f8be0079c531659141344cd1fd0a4f28419497f9722a3daafe3b4186f6b6457e060405160405180910390a3806000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff16021790555050565b604051806101000160405280600060ff16815260200160008152602001600061ffff168152602001600061ffff168152602001600060ff1681526020016000801916815260200160008019168152602001600067ffffffffffffffff168152509056fea265627a7a72315820b4fc12d2d0a41c0fc982bf855e6416c128107db8b8a0443a69b4d457fa80315564736f6c634300050d0032";
        public CitizensDeploymentBase() : base(BYTECODE) { }
        public CitizensDeploymentBase(string byteCode) : base(byteCode) { }
        [Parameter("address", "_galleass", 1)]
        public virtual string Galleass { get; set; }
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

    public partial class CreateCitizenFunction : CreateCitizenFunctionBase { }

    [Function("createCitizen", "uint256")]
    public class CreateCitizenFunctionBase : FunctionMessage
    {
        [Parameter("address", "_owner", 1)]
        public virtual string Owner { get; set; }
        [Parameter("uint8", "_status", 2)]
        public virtual byte Status { get; set; }
        [Parameter("uint256", "_data", 3)]
        public virtual BigInteger Data { get; set; }
        [Parameter("uint16", "_x", 4)]
        public virtual ushort X { get; set; }
        [Parameter("uint16", "_y", 5)]
        public virtual ushort Y { get; set; }
        [Parameter("uint8", "_tile", 6)]
        public virtual byte Tile { get; set; }
        [Parameter("bytes32", "_genes", 7)]
        public virtual byte[] Genes { get; set; }
        [Parameter("bytes32", "_characteristics", 8)]
        public virtual byte[] Characteristics { get; set; }
    }

    public partial class SetStatusFunction : SetStatusFunctionBase { }

    [Function("setStatus", "bool")]
    public class SetStatusFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_id", 1)]
        public virtual BigInteger Id { get; set; }
        [Parameter("uint8", "_status", 2)]
        public virtual byte Status { get; set; }
    }

    public partial class SetTileFunction : SetTileFunctionBase { }

    [Function("setTile", "bool")]
    public class SetTileFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_id", 1)]
        public virtual BigInteger Id { get; set; }
        [Parameter("uint8", "_tile", 2)]
        public virtual byte Tile { get; set; }
    }

    public partial class SetDataFunction : SetDataFunctionBase { }

    [Function("setData", "bool")]
    public class SetDataFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "_id", 1)]
        public virtual BigInteger Id { get; set; }
        [Parameter("uint256", "_data", 2)]
        public virtual BigInteger Data { get; set; }
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

    public partial class CitizenUpdateEventDTO : CitizenUpdateEventDTOBase { }

    [Event("CitizenUpdate")]
    public class CitizenUpdateEventDTOBase : IEventDTO
    {
        [Parameter("uint256", "id", 1, true )]
        public virtual BigInteger Id { get; set; }
        [Parameter("uint16", "x", 2, true )]
        public virtual ushort X { get; set; }
        [Parameter("uint16", "y", 3, true )]
        public virtual ushort Y { get; set; }
        [Parameter("uint8", "tile", 4, false )]
        public virtual byte Tile { get; set; }
        [Parameter("address", "owner", 5, false )]
        public virtual string Owner { get; set; }
        [Parameter("uint8", "status", 6, false )]
        public virtual byte Status { get; set; }
        [Parameter("uint256", "data", 7, false )]
        public virtual BigInteger Data { get; set; }
        [Parameter("bytes32", "genes", 8, false )]
        public virtual byte[] Genes { get; set; }
        [Parameter("bytes32", "characteristics", 9, false )]
        public virtual byte[] Characteristics { get; set; }
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
        [Parameter("uint8", "status", 2)]
        public virtual byte Status { get; set; }
        [Parameter("uint256", "data", 3)]
        public virtual BigInteger Data { get; set; }
        [Parameter("uint16", "x", 4)]
        public virtual ushort X { get; set; }
        [Parameter("uint16", "y", 5)]
        public virtual ushort Y { get; set; }
        [Parameter("uint8", "tile", 6)]
        public virtual byte Tile { get; set; }
        [Parameter("bytes32", "genes", 7)]
        public virtual byte[] Genes { get; set; }
        [Parameter("bytes32", "characteristics", 8)]
        public virtual byte[] Characteristics { get; set; }
        [Parameter("uint64", "birth", 9)]
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
