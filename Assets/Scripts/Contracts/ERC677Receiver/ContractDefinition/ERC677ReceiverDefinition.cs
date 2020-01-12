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

namespace Galleass3D.Contracts.ERC677Receiver.ContractDefinition
{


    public partial class ERC677ReceiverDeployment : ERC677ReceiverDeploymentBase
    {
        public ERC677ReceiverDeployment() : base(BYTECODE) { }
        public ERC677ReceiverDeployment(string byteCode) : base(byteCode) { }
    }

    public class ERC677ReceiverDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b5061016b806100206000396000f3fe608060405234801561001057600080fd5b506004361061002b5760003560e01c8063a4c0ed3614610030575b600080fd5b6101136004803603606081101561004657600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803590602001909291908035906020019064010000000081111561008d57600080fd5b82018360208201111561009f57600080fd5b803590602001918460018302840111640100000000831117156100c157600080fd5b91908080601f016020809104026020016040519081016040528093929190818152602001838380828437600081840152601f19601f82011690508083019250505050505050919291929050505061012d565b604051808215151515815260200191505060405180910390f35b6000939250505056fea265627a7a72315820391e1f15e8acd6e5cb12ec8674f554e94c169c1049ad819de70a6878a906122c64736f6c634300050d0032";
        public ERC677ReceiverDeploymentBase() : base(BYTECODE) { }
        public ERC677ReceiverDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class OnTokenTransferFunction : OnTokenTransferFunctionBase { }

    [Function("onTokenTransfer", "bool")]
    public class OnTokenTransferFunctionBase : FunctionMessage
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
        [Parameter("uint256", "", 2)]
        public virtual BigInteger ReturnValue2 { get; set; }
        [Parameter("bytes", "", 3)]
        public virtual byte[] ReturnValue3 { get; set; }
    }

    public partial class OnTokenTransferOutputDTO : OnTokenTransferOutputDTOBase { }

    [FunctionOutput]
    public class OnTokenTransferOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("bool", "", 1)]
        public virtual bool ReturnValue1 { get; set; }
    }
}
