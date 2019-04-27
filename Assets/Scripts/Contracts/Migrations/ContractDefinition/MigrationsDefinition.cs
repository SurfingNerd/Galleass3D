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

namespace Galleass3D.Contracts.Migrations.ContractDefinition
{


    public partial class MigrationsDeployment : MigrationsDeploymentBase
    {
        public MigrationsDeployment() : base(BYTECODE) { }
        public MigrationsDeployment(string byteCode) : base(byteCode) { }
    }

    public class MigrationsDeploymentBase : ContractDeploymentMessage
    {
        public static string BYTECODE = "0x608060405234801561001057600080fd5b50336000806101000a81548173ffffffffffffffffffffffffffffffffffffffff021916908373ffffffffffffffffffffffffffffffffffffffff1602179055506102e7806100606000396000f3fe608060405234801561001057600080fd5b5060043610610069576000357c0100000000000000000000000000000000000000000000000000000000900480630900f0101461006e578063445df0ac146100b25780638da5cb5b146100d0578063fdacd5761461011a575b600080fd5b6100b06004803603602081101561008457600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610148565b005b6100ba610230565b6040518082815260200191505060405180910390f35b6100d8610236565b604051808273ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200191505060405180910390f35b6101466004803603602081101561013057600080fd5b810190808035906020019092919050505061025b565b005b6000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff16141561022d5760008190508073ffffffffffffffffffffffffffffffffffffffff1663fdacd5766001546040518263ffffffff167c010000000000000000000000000000000000000000000000000000000002815260040180828152602001915050600060405180830381600087803b15801561021357600080fd5b505af1158015610227573d6000803e3d6000fd5b50505050505b50565b60015481565b6000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1681565b6000809054906101000a900473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff163373ffffffffffffffffffffffffffffffffffffffff1614156102b857806001819055505b5056fea165627a7a7230582099721258cf3b8f88c698a8f85f6d5f9070e8b629078d6b0fb088fa4a3f9fc45d0029";
        public MigrationsDeploymentBase() : base(BYTECODE) { }
        public MigrationsDeploymentBase(string byteCode) : base(byteCode) { }

    }

    public partial class Last_completed_migrationFunction : Last_completed_migrationFunctionBase { }

    [Function("last_completed_migration", "uint256")]
    public class Last_completed_migrationFunctionBase : FunctionMessage
    {

    }

    public partial class OwnerFunction : OwnerFunctionBase { }

    [Function("owner", "address")]
    public class OwnerFunctionBase : FunctionMessage
    {

    }

    public partial class SetCompletedFunction : SetCompletedFunctionBase { }

    [Function("setCompleted")]
    public class SetCompletedFunctionBase : FunctionMessage
    {
        [Parameter("uint256", "completed", 1)]
        public virtual BigInteger Completed { get; set; }
    }

    public partial class UpgradeFunction : UpgradeFunctionBase { }

    [Function("upgrade")]
    public class UpgradeFunctionBase : FunctionMessage
    {
        [Parameter("address", "new_address", 1)]
        public virtual string New_address { get; set; }
    }

    public partial class Last_completed_migrationOutputDTO : Last_completed_migrationOutputDTOBase { }

    [FunctionOutput]
    public class Last_completed_migrationOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("uint256", "", 1)]
        public virtual BigInteger ReturnValue1 { get; set; }
    }

    public partial class OwnerOutputDTO : OwnerOutputDTOBase { }

    [FunctionOutput]
    public class OwnerOutputDTOBase : IFunctionOutputDTO 
    {
        [Parameter("address", "", 1)]
        public virtual string ReturnValue1 { get; set; }
    }




}
