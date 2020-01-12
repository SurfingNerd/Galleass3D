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

namespace Galleass3D.Contracts.Roles.ContractDefinition
{


    public partial class RolesDeployment : RolesDeploymentBase
    {
        public RolesDeployment() : base(BYTECODE) { }
        public RolesDeployment(string byteCode) : base(byteCode) { }
    }

    public class RolesDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x60556023600b82828239805160001a607314601657fe5b30600052607381538281f3fe73000000000000000000000000000000000000000030146080604052600080fdfea265627a7a72315820cc1f1afbbb310f9980ebaf6d236e7befa68ca4feeb7ad8638628037209b17be564736f6c634300050d0032";
        public RolesDeploymentBase() : base(BYTECODE) { }
        public RolesDeploymentBase(string byteCode) : base(byteCode) { }

    }
}
