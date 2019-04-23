using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Nethereum;
using Nethereum.Contracts.CQS;
using Nethereum.JsonRpc.UnityClient;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System.Numerics;

public class EthKeyManager : MonoBehaviour {

    [Function("changeVendingMachine")]
    public class ChangeVendingMachineFunction : FunctionMessage
    {
        [Parameter("address", "newVendingMachine", 1)]
        public virtual string NewVendingMachine { get; set; }
    }

    [Function("mint", "bool")]
    public class MintFunction : FunctionMessage
    {
        [Parameter("address", "to", 1)]
        public string ToAddress { get; set; }

        [Parameter("uint256", "amount", 2)]
        public BigInteger Amount { get; set; }
    }

    [Function("balanceOf", "uint256")]
    public class BalanceOfFunction : FunctionMessage
    {
        [Parameter("address", "_owner", 1)]
        public string Owner { get; set; }
    }

    [FunctionOutput]
    public class BalanceOfFunctionOutput : IFunctionOutputDTO
    {
        [Parameter("uint256", 1)]
        public int Balance { get; set; }
    }

    public static EthKeyManager Instance { get; private set; }

    [SerializeField]
    public string RpcUrl;

    [SerializeField]
    public string PreselectedPrivateKey;

    private string privateKey;
    public string Address { get; private set; }


    void Reset() {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    void OnDestroy() {
        if (Instance == this)
        {
            Instance = null;
        }
    }

    // Use this for initialization
    void Start () {

		if (Instance != null) {
            UnityEngine.Debug.LogError("EthKeyManager is already set. Additional EthKeyManager dit not get started.");
            return;
		}

        if (string.IsNullOrEmpty(RpcUrl))
        {
            RpcUrl = "http://localhost:9545";
        }

        if (!string.IsNullOrEmpty(PreselectedPrivateKey))
        {
            privateKey = PreselectedPrivateKey;
        }


        //todo: find out how to create Key Pair

        Address =    "0x44FAe35d8A77794F60d65D8346c37da4af923134";
        privateKey = "B65C0964709083440649EB86F795D9DAB6FA14D28FECDEFC4C0A74189573FD65";

        //
        ///var url = ;
        //var PrivateKey = "0xb5b1870957d373ef0eeffecc6e4812c0fd08f554b37b233526acc331bf1544f7";
        //var account = "0x12890d2cce102216644c59daE5baed380d84830c";

        DeployTest();
    }

    private void DeployTest() 
    {
        Debug.Log("Deploying...");
                StartCoroutine(DoDeploySteps());
    }

    private IEnumerator DoDeploySteps()
    {
        Nethereum.Contracts.ContractDeploymentMessage deployMessage = new Nethereum.Contracts.ContractDeploymentMessage("0x608060405234801561001057600080fd5b506100293361002e640100000000026401000000009004565b6101e8565b61004f816003610095640100000000026110d1179091906401000000009004565b8073ffffffffffffffffffffffffffffffffffffffff167f6ae172837ea30b801fbfcdd4108aa1d5bf8ff775444fd70256b44e6bf3dfc3f660405160405180910390a250565b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff16141515156100d157600080fd5b6100ea8282610154640100000000026401000000009004565b1515156100f657600080fd5b60018260000160008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060006101000a81548160ff0219169083151502179055505050565b60008073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff161415151561019157600080fd5b8260000160008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060009054906101000a900460ff16905092915050565b61125c806101f76000396000f3fe608060405234801561001057600080fd5b5060043610610128576000357c01000000000000000000000000000000000000000000000000000000009004806370a08231116100bf578063a457c2d71161008e578063a457c2d7146104f1578063a9059cbb14610557578063aa271e1a146105bd578063dd62ed3e14610619578063f3ccaac01461069157610128565b806370a08231146103c857806395d89b4114610420578063983b2d56146104a357806398650275146104e757610128565b80632ff2e9dc116100fb5780632ff2e9dc146102ba578063313ce567146102d857806339509351146102fc57806340c10f191461036257610128565b806306fdde031461012d578063095ea7b3146101b057806318160ddd1461021657806323b872dd14610234575b600080fd5b6101356106af565b6040518080602001828103825283818151815260200191508051906020019080838360005b8381101561017557808201518184015260208101905061015a565b50505050905090810190601f1680156101a25780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b6101fc600480360360408110156101c657600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803590602001909291905050506106e8565b604051808215151515815260200191505060405180910390f35b61021e6106ff565b6040518082815260200191505060405180910390f35b6102a06004803603606081101561024a57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610709565b604051808215151515815260200191505060405180910390f35b6102c26107ba565b6040518082815260200191505060405180910390f35b6102e06107bf565b604051808260ff1660ff16815260200191505060405180910390f35b6103486004803603604081101561031257600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803590602001909291905050506107c4565b604051808215151515815260200191505060405180910390f35b6103ae6004803603604081101561037857600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610869565b604051808215151515815260200191505060405180910390f35b61040a600480360360208110156103de57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610893565b6040518082815260200191505060405180910390f35b6104286108db565b6040518080602001828103825283818151815260200191508051906020019080838360005b8381101561046857808201518184015260208101905061044d565b50505050905090810190601f1680156104955780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b6104e5600480360360208110156104b957600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610914565b005b6104ef610934565b005b61053d6004803603604081101561050757600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291908035906020019092919050505061093f565b604051808215151515815260200191505060405180910390f35b6105a36004803603604081101561056d57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803590602001909291905050506109e4565b604051808215151515815260200191505060405180910390f35b6105ff600480360360208110156105d357600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291905050506109fb565b604051808215151515815260200191505060405180910390f35b61067b6004803603604081101561062f57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610a18565b6040518082815260200191505060405180910390f35b610699610a9f565b6040518082815260200191505060405180910390f35b6040805190810160405280600b81526020017f456e657267792043656c6c00000000000000000000000000000000000000000081525081565b60006106f5338484610ac3565b6001905092915050565b6000600254905090565b6000610716848484610c26565b6107af84336107aa85600160008a73ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060003373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054610df290919063ffffffff16565b610ac3565b600190509392505050565b600081565b600081565b600061085f338461085a85600160003373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008973ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054610e1490919063ffffffff16565b610ac3565b6001905092915050565b6000610874336109fb565b151561087f57600080fd5b6108898383610e35565b6001905092915050565b60008060008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020549050919050565b6040805190810160405280600281526020017f454300000000000000000000000000000000000000000000000000000000000081525081565b61091d336109fb565b151561092857600080fd5b61093181610f89565b50565b61093d33610fe3565b565b60006109da33846109d585600160003373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008973ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054610df290919063ffffffff16565b610ac3565b6001905092915050565b60006109f1338484610c26565b6001905092915050565b6000610a1182600361103d90919063ffffffff16565b9050919050565b6000600160008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054905092915050565b7f656e6572677963656c6c0000000000000000000000000000000000000000000081565b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff1614151515610aff57600080fd5b600073ffffffffffffffffffffffffffffffffffffffff168373ffffffffffffffffffffffffffffffffffffffff1614151515610b3b57600080fd5b80600160008573ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020819055508173ffffffffffffffffffffffffffffffffffffffff168373ffffffffffffffffffffffffffffffffffffffff167f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925836040518082815260200191505060405180910390a3505050565b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff1614151515610c6257600080fd5b610cb3816000808673ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054610df290919063ffffffff16565b6000808573ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002081905550610d46816000808573ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054610e1490919063ffffffff16565b6000808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020819055508173ffffffffffffffffffffffffffffffffffffffff168373ffffffffffffffffffffffffffffffffffffffff167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef836040518082815260200191505060405180910390a3505050565b6000828211151515610e0357600080fd5b600082840390508091505092915050565b6000808284019050838110151515610e2b57600080fd5b8091505092915050565b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff1614151515610e7157600080fd5b610e8681600254610e1490919063ffffffff16565b600281905550610edd816000808573ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054610e1490919063ffffffff16565b6000808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020819055508173ffffffffffffffffffffffffffffffffffffffff16600073ffffffffffffffffffffffffffffffffffffffff167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef836040518082815260200191505060405180910390a35050565b610f9d8160036110d190919063ffffffff16565b8073ffffffffffffffffffffffffffffffffffffffff167f6ae172837ea30b801fbfcdd4108aa1d5bf8ff775444fd70256b44e6bf3dfc3f660405160405180910390a250565b610ff781600361118190919063ffffffff16565b8073ffffffffffffffffffffffffffffffffffffffff167fe94479a9f7e1952cc78f2d6baab678adc1b772d936c6583def489e524cb6669260405160405180910390a250565b60008073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff161415151561107a57600080fd5b8260000160008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060009054906101000a900460ff16905092915050565b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff161415151561110d57600080fd5b611117828261103d565b15151561112357600080fd5b60018260000160008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060006101000a81548160ff0219169083151502179055505050565b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff16141515156111bd57600080fd5b6111c7828261103d565b15156111d257600080fd5b60008260000160008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060006101000a81548160ff021916908315150217905550505056fea165627a7a72305820718ad52cdc7d599b27271362a72d1828e124674c8f752a9d35c022f0695c4cc80029");
        //TransactionSignedUnityRequest deployResult = SendDeployMessage(deployMessage);
        yield return SendDeployMessage(deployMessage);
    }

    public IEnumerator SendDeployMessage(Nethereum.Contracts.ContractDeploymentMessage message)
    {
        var requestDeployment = new TransactionSignedUnityRequest(RpcUrl, privateKey, Address);
        yield return requestDeployment.SignAndSendDeploymentContractTransaction(message);

        if (requestDeployment.Exception != null)
        {
            Debug.LogError("Error Deploying Contract:" + requestDeployment.Exception);
            yield break;
        } 
        else
        {

            Debug.Log("Success:" + requestDeployment.Result);
            
            //EthGetTransactionByHashUnityRequest requestDeployTransactionDetails =
            //    new EthGetTransactionByHashUnityRequest(RpcUrl);

            //yield return requestDeployTransactionDetails.SendRequest(requestDeployment.Result);

            //string contractAdress = "";
            //if (requestDeployTransactionDetails.Exception != null)
            //{
            //    Debug.LogError("Retrieving transaction Details ran into a Error:" + requestDeployTransactionDetails.Exception);
            //}
            //else
            //{
            //    Debug.Log("Deployment success:" + requestDeployTransactionDetails.Result.);
            //contractAdress = requestDeployTransactionDetails.Result
            //}

            //create a poll to get the receipt when mined
            var transactionReceiptPolling = new TransactionReceiptPollingRequest(RpcUrl);
            //checking every 2 seconds for the receipt
            yield return transactionReceiptPolling.PollForReceipt(requestDeployment.Result, 1);
            var deploymentReceipt = transactionReceiptPolling.Result;

            Debug.Log("Deployment contract address:" + deploymentReceipt.ContractAddress);

            MintFunction mint = new MintFunction();
            mint.ToAddress = Address;
            mint.Amount = 1000000;
            mint.Gas = 1353239;

            TransactionSignedUnityRequest requestMint = CreateSignedRequest();
            yield return requestMint.SignAndSendTransaction(mint, deploymentReceipt.ContractAddress);

            if (requestMint.Exception != null)
            {
                Debug.LogError("ignoring Minting Error: " + requestMint.Exception);
            }
            else
            {
                Debug.Log("Mint Successfull!" + requestMint.Result);
            }


            //Query request using our acccount and the contracts address (no parameters needed and default values)
            var queryRequest = new QueryUnityRequest<BalanceOfFunction, BalanceOfFunctionOutput>(RpcUrl, Address);

            yield return queryRequest.Query(new BalanceOfFunction() { Owner = Address }, deploymentReceipt.ContractAddress);


            if (queryRequest.Exception != null)
            {
                Debug.LogError("Error getting Balance: " + queryRequest.Exception);
            }
            else
            {
                //Getting the dto response already decoded
                var dtoResult = queryRequest.Result;
                Debug.Log("Minted: " + dtoResult.Balance);
            }



            //ChangeVendingMachineFunction changeVendingMachine = new ChangeVendingMachineFunction();
            //changeVendingMachine.NewVendingMachine = Address;

            //TransactionSignedUnityRequest requestChangeVendingMachine = CreateSignedRequest();

            //yield return requestChangeVendingMachine.SignAndSendTransaction(changeVendingMachine, deploymentReceipt.ContractAddress);

            //if (requestChangeVendingMachine.Exception != null)
            //{
            //    Debug.LogError("Error at contract call" + requestChangeVendingMachine.Result + ":" + requestChangeVendingMachine.Exception);
            //    yield break;
            //}
            //else
            //{
            //    Debug.Log("VendingMachine Success!!");

            //}

            //yield return changeVendingMachine .(transactionMessage, deploymentReceipt.ContractAddress);



            //new EthTransferUnityRequest(url, privateKey, account);
        }
    }

    private TransactionSignedUnityRequest CreateSignedRequest()
    {
        return new TransactionSignedUnityRequest(RpcUrl, privateKey, Address);
    }

    public void CreateNewRandomPrivateKey()
    {
        Nethereum.KeyStore.Crypto.KeyStoreCrypto keyStore = new Nethereum.KeyStore.Crypto.KeyStoreCrypto();
        //keyStore.
    }

    // Update is called once per frame
    void Update () {
		
	}
}
