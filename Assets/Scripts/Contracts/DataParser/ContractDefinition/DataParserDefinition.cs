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

namespace Galleass3D.Contracts.DataParser.ContractDefinition
{


    public partial class DataParserDeployment : DataParserDeploymentBase
    {
        public DataParserDeployment() : base(BYTECODE) { }
        public DataParserDeployment(string byteCode) : base(byteCode) { }
    }

    public class DataParserDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x6080604052348015600f57600080fd5b50603580601d6000396000f3006080604052600080fd00a165627a7a723058201e0cdd68e99181c0bd50098f62a892c8e85ce2986333c6b6b700cf6f012f09c60029";
        public DataParserDeploymentBase() : base(BYTECODE) { }
        public DataParserDeploymentBase(string byteCode) : base(byteCode) { }

    }
}
