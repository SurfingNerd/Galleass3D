﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Nethereum;
using Nethereum.Contracts.CQS;
using Nethereum.JsonRpc.UnityClient;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;
using System.Numerics;
using System;
using System.Text;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Web3.Accounts;
using System.Threading.Tasks;
using Galleass3D.Contracts;
using System.Threading;

public class EthKeyManager : MonoBehaviour {


    [SerializeField]
    public string RpcUrl;

    [SerializeField]
    public string PreselectedPrivateKey;

    [SerializeField]
    public GameObject BlockInfoText;


    string Words = "visit require silent museum allow awesome cook topple gauge lend rain mixed";
    string Password = "";

    //string Words = "ripple scissors kick mammal hire column oak again sun offer wealth tomorrow wagon turn fatal";
    //string Password = "password";
    Nethereum.HdWallet.Wallet Wallet; // = new Nethereum.HdWallet.Wallet(Words, Password);
    private Account Account;
    private Nethereum.Web3.Web3 Web3;
    private Galleass3D.Contracts.WorldsRegistry.WorldsRegistryService WorldsRegistry;

    private Galleass3D.Contracts.Galleass.GalleassService Galleass;
    private Galleass3D.Contracts.Timber.TimberService Timber;
    private Galleass3D.Contracts.Fillet.FilletService Fillet;
    private Galleass3D.Contracts.Dogger.DoggerService Dogger;
    private Galleass3D.Contracts.Bay.BayService Bay;
    private Galleass3D.Contracts.Citizens.CitizensService Citizens;
    private Galleass3D.Contracts.CitizensLib.CitizensLibService CitizensLib;
    private Galleass3D.Contracts.Land.LandService Land;
    private Galleass3D.Contracts.TimberCamp.TimberCampService TimberCamp;
    private Galleass3D.Contracts.LandLib.LandLibService LandLib;
    private Galleass3D.Contracts.Harbor.HarborService Harbor;
    private Galleass3D.Contracts.Fishmonger.FishmongerService Fishmonger;
    private Galleass3D.Contracts.Village.VillageService Village;
    private Galleass3D.Contracts.Market.MarketService Market;
    private Galleass3D.Contracts.Sea.SeaService Sea;

    //fishes.
    private Galleass3D.Contracts.Catfish.CatfishService Catfish;

    private ulong LastBlockNumber;

    private string LatestBlockInformation; 


    //event Handlers.
    Event<Galleass3D.Contracts.Bay.ContractDefinition.FishEventDTO> Bay_FishEventHandler;

    int BlockTimeMs = 1000;

    //&& account = Wallet.GetAccount(0);
    //var toAddress = "0x13f022d72158410433cbd66f5dd8bf6d2d129924";
    //var web3 = new Web3(account);

    // Nethereum.Web3.Web3 web3 = new Nethereum.Web3.Web3(new Nethereum.HdWallet.Wallet("", ""));

    private string WorldsRegistryAddress = "0x6EB0fadc34060AF5EfB053b4cB413CE5809b6f16";

    private string LastKnownGalleassAddress = "0xDaCAAcC9A3893f94e1a3d5Da240CE95C649Fb748";

    bool ShallRun = true;

    private async Task<bool> StartBlockchainCommunication()
    {
        Debug.Log("Starting Blockchain Communication");
        //byte[] bytes = new byte[32];
        //string x = await WorldsRegistry.WorldsQueryAsync(null);

        //Task updatePanelTask = UpdateUIPanel();
        //updatePanelTask.Start();


        System.Threading.Thread thread = new System.Threading.Thread(new ThreadStart(UpdateUIPanel));
        thread.Start();


        Galleass = new Galleass3D.Contracts.Galleass.GalleassService(Web3, LastKnownGalleassAddress);
        Timber = await GetContract<Galleass3D.Contracts.Timber.TimberService>();
        Fillet = await GetContract<Galleass3D.Contracts.Fillet.FilletService>();
        Dogger = await GetContract < Galleass3D.Contracts.Dogger.DoggerService>();
        Bay =   await GetContract<Galleass3D.Contracts.Bay.BayService>();
        Citizens = await GetContract<Galleass3D.Contracts.Citizens.CitizensService>();
        CitizensLib = await GetContract<Galleass3D.Contracts.CitizensLib.CitizensLibService>();
        Land = await GetContract<Galleass3D.Contracts.Land.LandService>();
        TimberCamp = await GetContract<Galleass3D.Contracts.TimberCamp.TimberCampService>();
        LandLib = await GetContract<Galleass3D.Contracts.LandLib.LandLibService>();
        Harbor = await GetContract<Galleass3D.Contracts.Harbor.HarborService>();
        Fishmonger = await GetContract<Galleass3D.Contracts.Fishmonger.FishmongerService>();
        Village = await GetContract < Galleass3D.Contracts.Village.VillageService>();
        Market = await GetContract<Galleass3D.Contracts.Market.MarketService>();
        Sea = await GetContract<Galleass3D.Contracts.Sea.SeaService>();

        //fishes
        Catfish = await GetContract<Galleass3D.Contracts.Catfish.CatfishService>();



        //Web3.Eth.GetContract(Galleass3D.Contracts.Bay.ContractDefinition )

        //register events
        //Bay.Fish
        //Galleass3D.Contracts.Bay.ContractDefinition.FishEventDTO fishEvent = new Galleass3D.Contracts.Bay.ContractDefinition.FishEventDTO();


        //var fishEventHandler = Web3.Eth.GetEvent<Galleass3D.Contracts.Bay.ContractDefinition.FishEventDTO>(Bay.ContractHandler.ContractAddress);

        Bay_FishEventHandler = Bay.ContractHandler.GetEvent<Galleass3D.Contracts.Bay.ContractDefinition.FishEventDTO>();



        //StartCoroutine(ParseEvents());

        //ParseEventsAsync();
        //System.Threading.Tasks.Task parseEvents = new Task(() => ParseEventsRaw());
        //parseEvents.Start();

        //System.Threading.Thread thread = new System.Threading.Thread(new ThreadStart(ParseEventsRaw));
        //thread.Start();


        //ulong currentBlock = 1;
        //StartCoroutine(ParseEvents(currentBlock));


        //blockWithTransactions.
        //Web3.Eth.GetContract()

        Debug.Log("Minting Catfish");
        TransactionReceipt mintedCatfish = await  Catfish.MintRequestAndWaitForReceiptAsync(Account.Address, 10);

        Debug.Log("Allowing Catfish in Bay");
        TransactionReceipt allowCatfishInBay = await Bay.AllowSpeciesRequestAndWaitForReceiptAsync(5, 5, Catfish.ContractHandler.ContractAddress);

        Debug.Log("Stocking Catfish in Bay");
        TransactionReceipt stockCatfishInBay = await Bay.StockRequestAndWaitForReceiptAsync(5, 5, Catfish.ContractHandler.ContractAddress, 5);
        Debug.Log("Stocking Catfish in Bay -finished!");
        DebugTransactionReceipt(stockCatfishInBay);
        //Bay.FishQueryAsync()

        return true;
    }

    void HandleParameterizedThreadStart(object obj)
    {
    }


    private void DebugTransactionReceipt(TransactionReceipt receipt)
    {
        string hasErrors = receipt.HasErrors().HasValue ? receipt.HasErrors().Value.ToString() : "???";

        Debug.Log("TransactionHash: " + receipt.TransactionHash);
        Debug.Log("HasErrors: " + hasErrors);
        Debug.Log("Status: " + receipt.Status.Value.ToString());

        Debug.Log("Logs: " + receipt.Logs);
        //foreach(var log in receipt.Logs)


    }

    private ulong GetCurrentBlockNumber() 
    {
        var task = Web3.Eth.Blocks.GetBlockNumber.SendRequestAsync();
        //task.RunSynchronously();
        //task.Start();
        task.Wait();
        //Debug.Log("Current Block Number = " + task.Result.Value.ToString());
        return ulong.Parse(task.Result.Value.ToString());
    }

    private void ParseEventsRaw()
    {
        while (ShallRun)
        {
            ulong startBlockNumber = GetCurrentBlockNumber() - 1;
           //HandleFishEvents(startBlockNumber);

            System.Threading.Thread.Sleep(BlockTimeMs);
        }

    }

    //private IEnumerator ParseEvents()
    //{
    //    Debug.Log("Starting Parsing Events");
    //    while(ShallRun)
    //    {
    //        ulong startBlockNumber = GetCurrentBlockNumber() - 1;
    //        HandleFishEvents(startBlockNumber);
    //        System.Threading.Thread.Sleep(BlockTimeMs);
    //         Web3.Eth.Blocks.GetBlockNumber.SendRequestAsync();
    //        yield return startBlockNumber;
    //    }
    //}

    private async Task HandleFishEvents(ulong startBlockNumber)
    {
        //Debug.Log("Parsing events starting at Block " + startBlockNumber.ToString());
        var fishEvents = await Bay_FishEventHandler.GetAllChanges(new NewFilterInput() { FromBlock = new BlockParameter(startBlockNumber) });

        foreach(var fishEvent in fishEvents)
        {
            //DateTime ts = new DateTime(fishEvent.Event.Timestamp);
            Debug.Log("Found a fish at" + fishEvent.Event.X + " " + fishEvent.Event.Y + " ID" + fishEvent.Event.Id + " ts: " + fishEvent.Event.Timestamp + "species: " + fishEvent.Event.Species);
        }
    }

    private async Task<T> GetContract<T>()
    {
        string contractName = typeof(T).Name.Trim();
        contractName = contractName.Substring(0, contractName.Length - "Service".Length);
        Debug.Log("Getting Contract address:" + contractName);
        string contractAddress = await Galleass.GetContractQueryAsync(Encoding.ASCII.GetBytes(contractName));
        Debug.Log("Getting Contract:" + contractName + " at address " + contractAddress);
        T result = (T)Activator.CreateInstance(typeof(T), Web3, contractAddress);

        return result;
    }



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
            //RpcUrl = "http://localhost:9545";
            RpcUrl = "http://116.203.118.82:8545";
            //RpcUrl = "https://rpc.tau1.artis.network";
        }

        //if (!string.IsNullOrEmpty(PreselectedPrivateKey))
        //{
        //    privateKey = PreselectedPrivateKey;
        //}



        Wallet = new Nethereum.HdWallet.Wallet(Words, Password);

        Account = Wallet.GetAccount(0);


        Debug.Log("Address: " + Account.Address);
        //Wallet.GetAccount(0);
        //todo: find out how to create Key Pair
        Web3 = new Nethereum.Web3.Web3(Account, RpcUrl);


        WorldsRegistry = new Galleass3D.Contracts.WorldsRegistry.WorldsRegistryService(Web3, WorldsRegistryAddress);

        

        //StartCoroutine(UpdateUIPanel());

        //TODO: find out how to call a async function on purpose.
#pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
        StartBlockchainCommunication();
#pragma warning restore CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed



        //Address =    "0x44FAe35d8A77794F60d65D8346c37da4af923134";
        //privateKey = "B65C0964709083440649EB86F795D9DAB6FA14D28FECDEFC4C0A74189573FD65";


        // Address = Account.Address;

        //
        ///var url = ;
        //var PrivateKey = "0xb5b1870957d373ef0eeffecc6e4812c0fd08f554b37b233526acc331bf1544f7";
        //var account = "0x12890d2cce102216644c59daE5baed380d84830c";

        //DeployTest();




    }

    void UpdateUIPanel()
    {
        LastBlockNumber = GetCurrentBlockNumber();
        while (true) 
        {
            ulong newBlockNumber = GetCurrentBlockNumber();

            //Web3.Eth.Blocks.GetBlockNumber();
            if (newBlockNumber > LastBlockNumber)
            {
                var blockNumber = new Nethereum.Hex.HexTypes.HexBigInteger(new BigInteger(newBlockNumber));

                var block = Web3.Eth.Blocks.GetBlockWithTransactionsByNumber.SendRequestAsync(blockNumber);
                block.Wait();
                var result = block.Result;

               // var result = Web3.Eth.Blocks.GetBlockWithTransactionsByNumber.SendRequestAsync(blockNumber);

                StringBuilder txInfos = new StringBuilder();
                txInfos.AppendLine(newBlockNumber.ToString());
                txInfos.AppendLine(result.BlockHash);
                foreach(var tx in result.Transactions)
                {
                    txInfos.AppendLine(" - " + tx.TransactionHash);
                    //tx.TransactionHash;
                    //tx.
                    //tx.
                }

                LatestBlockInformation = txInfos.ToString();
                //block.Result.Transactions
            }



            System.Threading.Thread.Sleep(BlockTimeMs);
        }
    }

    private void SetText(GameObject textHostObject, string text)
    {
        if (textHostObject != null)
        {
            UnityEngine.UI.Text txComponent = BlockInfoText.GetComponent<UnityEngine.UI.Text>();
            txComponent.text = text;
        }
    }

    private void DeployTest() 
    {
        Debug.Log("Deploying...");
                StartCoroutine(DoDeploySteps());
    }

    private IEnumerator DoDeploySteps()
    {
        yield break;
        //Nethereum.Contracts.ContractDeploymentMessage deployMessage = new Nethereum.Contracts.ContractDeploymentMessage("0x608060405234801561001057600080fd5b506100293361002e640100000000026401000000009004565b6101e8565b61004f816003610095640100000000026110d1179091906401000000009004565b8073ffffffffffffffffffffffffffffffffffffffff167f6ae172837ea30b801fbfcdd4108aa1d5bf8ff775444fd70256b44e6bf3dfc3f660405160405180910390a250565b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff16141515156100d157600080fd5b6100ea8282610154640100000000026401000000009004565b1515156100f657600080fd5b60018260000160008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060006101000a81548160ff0219169083151502179055505050565b60008073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff161415151561019157600080fd5b8260000160008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060009054906101000a900460ff16905092915050565b61125c806101f76000396000f3fe608060405234801561001057600080fd5b5060043610610128576000357c01000000000000000000000000000000000000000000000000000000009004806370a08231116100bf578063a457c2d71161008e578063a457c2d7146104f1578063a9059cbb14610557578063aa271e1a146105bd578063dd62ed3e14610619578063f3ccaac01461069157610128565b806370a08231146103c857806395d89b4114610420578063983b2d56146104a357806398650275146104e757610128565b80632ff2e9dc116100fb5780632ff2e9dc146102ba578063313ce567146102d857806339509351146102fc57806340c10f191461036257610128565b806306fdde031461012d578063095ea7b3146101b057806318160ddd1461021657806323b872dd14610234575b600080fd5b6101356106af565b6040518080602001828103825283818151815260200191508051906020019080838360005b8381101561017557808201518184015260208101905061015a565b50505050905090810190601f1680156101a25780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b6101fc600480360360408110156101c657600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803590602001909291905050506106e8565b604051808215151515815260200191505060405180910390f35b61021e6106ff565b6040518082815260200191505060405180910390f35b6102a06004803603606081101561024a57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610709565b604051808215151515815260200191505060405180910390f35b6102c26107ba565b6040518082815260200191505060405180910390f35b6102e06107bf565b604051808260ff1660ff16815260200191505060405180910390f35b6103486004803603604081101561031257600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803590602001909291905050506107c4565b604051808215151515815260200191505060405180910390f35b6103ae6004803603604081101561037857600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610869565b604051808215151515815260200191505060405180910390f35b61040a600480360360208110156103de57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610893565b6040518082815260200191505060405180910390f35b6104286108db565b6040518080602001828103825283818151815260200191508051906020019080838360005b8381101561046857808201518184015260208101905061044d565b50505050905090810190601f1680156104955780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b6104e5600480360360208110156104b957600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610914565b005b6104ef610934565b005b61053d6004803603604081101561050757600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291908035906020019092919050505061093f565b604051808215151515815260200191505060405180910390f35b6105a36004803603604081101561056d57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803590602001909291905050506109e4565b604051808215151515815260200191505060405180910390f35b6105ff600480360360208110156105d357600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291905050506109fb565b604051808215151515815260200191505060405180910390f35b61067b6004803603604081101561062f57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610a18565b6040518082815260200191505060405180910390f35b610699610a9f565b6040518082815260200191505060405180910390f35b6040805190810160405280600b81526020017f456e657267792043656c6c00000000000000000000000000000000000000000081525081565b60006106f5338484610ac3565b6001905092915050565b6000600254905090565b6000610716848484610c26565b6107af84336107aa85600160008a73ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060003373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054610df290919063ffffffff16565b610ac3565b600190509392505050565b600081565b600081565b600061085f338461085a85600160003373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008973ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054610e1490919063ffffffff16565b610ac3565b6001905092915050565b6000610874336109fb565b151561087f57600080fd5b6108898383610e35565b6001905092915050565b60008060008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020549050919050565b6040805190810160405280600281526020017f454300000000000000000000000000000000000000000000000000000000000081525081565b61091d336109fb565b151561092857600080fd5b61093181610f89565b50565b61093d33610fe3565b565b60006109da33846109d585600160003373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008973ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054610df290919063ffffffff16565b610ac3565b6001905092915050565b60006109f1338484610c26565b6001905092915050565b6000610a1182600361103d90919063ffffffff16565b9050919050565b6000600160008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054905092915050565b7f656e6572677963656c6c0000000000000000000000000000000000000000000081565b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff1614151515610aff57600080fd5b600073ffffffffffffffffffffffffffffffffffffffff168373ffffffffffffffffffffffffffffffffffffffff1614151515610b3b57600080fd5b80600160008573ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020819055508173ffffffffffffffffffffffffffffffffffffffff168373ffffffffffffffffffffffffffffffffffffffff167f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925836040518082815260200191505060405180910390a3505050565b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff1614151515610c6257600080fd5b610cb3816000808673ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054610df290919063ffffffff16565b6000808573ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002081905550610d46816000808573ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054610e1490919063ffffffff16565b6000808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020819055508173ffffffffffffffffffffffffffffffffffffffff168373ffffffffffffffffffffffffffffffffffffffff167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef836040518082815260200191505060405180910390a3505050565b6000828211151515610e0357600080fd5b600082840390508091505092915050565b6000808284019050838110151515610e2b57600080fd5b8091505092915050565b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff1614151515610e7157600080fd5b610e8681600254610e1490919063ffffffff16565b600281905550610edd816000808573ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054610e1490919063ffffffff16565b6000808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020819055508173ffffffffffffffffffffffffffffffffffffffff16600073ffffffffffffffffffffffffffffffffffffffff167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef836040518082815260200191505060405180910390a35050565b610f9d8160036110d190919063ffffffff16565b8073ffffffffffffffffffffffffffffffffffffffff167f6ae172837ea30b801fbfcdd4108aa1d5bf8ff775444fd70256b44e6bf3dfc3f660405160405180910390a250565b610ff781600361118190919063ffffffff16565b8073ffffffffffffffffffffffffffffffffffffffff167fe94479a9f7e1952cc78f2d6baab678adc1b772d936c6583def489e524cb6669260405160405180910390a250565b60008073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff161415151561107a57600080fd5b8260000160008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060009054906101000a900460ff16905092915050565b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff161415151561110d57600080fd5b611117828261103d565b15151561112357600080fd5b60018260000160008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060006101000a81548160ff0219169083151502179055505050565b600073ffffffffffffffffffffffffffffffffffffffff168173ffffffffffffffffffffffffffffffffffffffff16141515156111bd57600080fd5b6111c7828261103d565b15156111d257600080fd5b60008260000160008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060006101000a81548160ff021916908315150217905550505056fea165627a7a72305820718ad52cdc7d599b27271362a72d1828e124674c8f752a9d35c022f0695c4cc80029");
        //TransactionSignedUnityRequest deployResult = SendDeployMessage(deployMessage);
        //yield return SendDeployMessage(deployMessage);
    }

    private void LogErrorException(string message, Exception exception)
    {
        Debug.LogError(message +":" + exception);
        LogErrorRecursive(exception.InnerException);
    }

    private void LogErrorRecursive(Exception exception)
    {
        if (exception != null)
        {
            Debug.LogError("InnerException: " + exception);
            LogErrorRecursive(exception.InnerException);
        }
    }

    //public IEnumerator SendDeployMessage(Nethereum.Contracts.ContractDeploymentMessage message)
    //{
    //    EthBlockNumberUnityRequest blockNumberRequest = new EthBlockNumberUnityRequest(RpcUrl);
    //    yield return blockNumberRequest.SendRequest();

    //    if (blockNumberRequest.Exception != null)
    //    {
    //        LogErrorException("Failed To get Block Number: ", blockNumberRequest.Exception);
    //    } 
    //    else
    //    {
    //        Debug.Log("Latest Block Number: " + blockNumberRequest.Result.HexValue);
    //    }

    //    EthGetBalanceUnityRequest getBalanceRequest = new EthGetBalanceUnityRequest(RpcUrl);
    //    yield return getBalanceRequest.SendRequest(Address, Nethereum.RPC.Eth.DTOs.BlockParameter.CreateLatest());
    //    if (getBalanceRequest.Exception != null)
    //    {
    //        LogErrorException("Unable to get Balance:", getBalanceRequest.Exception);
    //    }
    //    else
    //    {
    //        Debug.Log("Balance: " + getBalanceRequest.Result.Value.ToString());
    //    }

    //    var requestDeployment = new TransactionSignedUnityRequest(RpcUrl, privateKey);
    //    message.GasPrice = 1000000000;
    //    //message.Gas = 8000000;
    //    yield return requestDeployment.SignAndSendDeploymentContractTransaction(message);


    //    if (requestDeployment.Exception != null)
    //    {
    //        LogErrorException("Error Deploying Contract:", requestDeployment.Exception);
    //        yield break;
    //    } 
    //    else
    //    {

    //        Debug.Log("Success:" + requestDeployment.Result);

    //        //EthGetTransactionByHashUnityRequest requestDeployTransactionDetails =
    //        //    new EthGetTransactionByHashUnityRequest(RpcUrl);

    //        //yield return requestDeployTransactionDetails.SendRequest(requestDeployment.Result);

    //        //string contractAdress = "";
    //        //if (requestDeployTransactionDetails.Exception != null)
    //        //{
    //        //    Debug.LogError("Retrieving transaction Details ran into a Error:" + requestDeployTransactionDetails.Exception);
    //        //}
    //        //else
    //        //{
    //        //    Debug.Log("Deployment success:" + requestDeployTransactionDetails.Result.);
    //        //contractAdress = requestDeployTransactionDetails.Result
    //        //}

    //        TransactionReceipt deploymentReceipt = GetReceipt(requestDeployment.Result, "Deployment contract");

    //        Debug.Log("Deployment contract address:" + deploymentReceipt.ContractAddress);

    //        MintFunction mint = new MintFunction();
    //        mint.ToAddress = Address;
    //        mint.Amount = 1000000;
    //        mint.Gas = 1353239;

    //        TransactionSignedUnityRequest requestMint = CreateSignedRequest();
    //        yield return requestMint.SignAndSendTransaction(mint, deploymentReceipt.ContractAddress);

    //        if (requestMint.Exception != null)
    //        {
    //            Debug.LogError("ignoring Minting Error: " + requestMint.Exception);
    //        }
    //        else
    //        {
    //            Debug.Log("Mint sent!" + requestMint.Result);

    //            GetReceipt(requestMint.Result, "Minting");
    //        }


    //        //Query request using our acccount and the contracts address (no parameters needed and default values)
    //        var queryRequest = new QueryUnityRequest<BalanceOfFunction, BalanceOfFunctionOutput>(RpcUrl, Address);

    //        yield return queryRequest.Query(new BalanceOfFunction() { Owner = Address }, deploymentReceipt.ContractAddress);


    //        if (queryRequest.Exception != null)
    //        {
    //            Debug.LogError("Error getting Balance: " + queryRequest.Exception);
    //        }
    //        else
    //        {
    //            //Getting the dto response already decoded
    //            var dtoResult = queryRequest.Result;
    //            Debug.Log("Minted: " + dtoResult.Balance);


    //        }





    //        //ChangeVendingMachineFunction changeVendingMachine = new ChangeVendingMachineFunction();
    //        //changeVendingMachine.NewVendingMachine = Address;

    //        //TransactionSignedUnityRequest requestChangeVendingMachine = CreateSignedRequest();

    //        //yield return requestChangeVendingMachine.SignAndSendTransaction(changeVendingMachine, deploymentReceipt.ContractAddress);

    //        //if (requestChangeVendingMachine.Exception != null)
    //        //{
    //        //    Debug.LogError("Error at contract call" + requestChangeVendingMachine.Result + ":" + requestChangeVendingMachine.Exception);
    //        //    yield break;
    //        //}
    //        //else
    //        //{
    //        //    Debug.Log("VendingMachine Success!!");

    //        //}

    //        //yield return changeVendingMachine .(transactionMessage, deploymentReceipt.ContractAddress);



    //        //new EthTransferUnityRequest(url, privateKey, account);
    //    }
    //}

    //private TransactionReceipt GetReceipt(string transactionHash, string operationLabel = "")
    //{
    //    Debug.Log("GetReceipt");

    //    var transactionReceiptPolling = new TransactionReceiptPollingRequest(RpcUrl);
    //    //checking every 2 seconds for the receipt

    //    var pollLoop =  transactionReceiptPolling.PollForReceipt(transactionHash, 1);
    //    while (pollLoop.MoveNext())
    //    {
    //        Debug.Log("polling: " + pollLoop.Current);
    //    }


    //    var deploymentReceipt = transactionReceiptPolling.Result;

    //    if (deploymentReceipt.HasErrors() == true)
    //    {
    //        //StringBuilder sb = new StringBuilder();
    //        Debug.LogError(operationLabel + transactionHash + "failed: " + deploymentReceipt.Logs.ToString());
    //        return deploymentReceipt;
    //    }

    //    if (!string.IsNullOrEmpty(deploymentReceipt.ContractAddress))
    //    {
    //        Debug.LogError(operationLabel + " - " + transactionHash + "succes!");
    //    }

    //    return deploymentReceipt;
    //}

    //private TransactionSignedUnityRequest CreateSignedRequest()
    //{
    //    return new TransactionSignedUnityRequest(RpcUrl, privateKey);
    //}

    //public void CreateNewRandomPrivateKey()
    //{
    //    Nethereum.KeyStore.Crypto.KeyStoreCrypto keyStore = new Nethereum.KeyStore.Crypto.KeyStoreCrypto();
    //    //keyStore.
    //}

    // Update is called once per frame
    void Update () 
    {
        SetText(BlockInfoText, LatestBlockInformation);
    }
}
