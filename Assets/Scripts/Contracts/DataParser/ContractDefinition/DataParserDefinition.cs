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
        public static string BYTECODE = "0x6080604052348015600f57600080fd5b50603e80601d6000396000f3fe6080604052600080fdfea265627a7a72315820c1d798382591ae0bd8790a7ac53b959785b4ade059e55e8c79f3177011fda32c64736f6c634300050d0032";
        public DataParserDeploymentBase() : base(BYTECODE) { }
        public DataParserDeploymentBase(string byteCode) : base(byteCode) { }

    }
}
