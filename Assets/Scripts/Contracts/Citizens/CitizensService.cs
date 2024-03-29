using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Numerics;
using Nethereum.Hex.HexTypes;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Web3;
using Nethereum.RPC.Eth.DTOs;
using Nethereum.Contracts.CQS;
using Nethereum.Contracts.ContractHandlers;
using Nethereum.Contracts;
using System.Threading;
using Galleass3D.Contracts.Citizens.ContractDefinition;

namespace Galleass3D.Contracts.Citizens
{
    public partial class CitizensService
    {
        public static Task<TransactionReceipt> DeployContractAndWaitForReceiptAsync(Nethereum.Web3.Web3 web3, CitizensDeployment citizensDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            return web3.Eth.GetContractDeploymentHandler<CitizensDeployment>().SendRequestAndWaitForReceiptAsync(citizensDeployment, cancellationTokenSource);
        }

        public static Task<string> DeployContractAsync(Nethereum.Web3.Web3 web3, CitizensDeployment citizensDeployment)
        {
            return web3.Eth.GetContractDeploymentHandler<CitizensDeployment>().SendRequestAsync(citizensDeployment);
        }

        public static async Task<CitizensService> DeployContractAndGetServiceAsync(Nethereum.Web3.Web3 web3, CitizensDeployment citizensDeployment, CancellationTokenSource cancellationTokenSource = null)
        {
            var receipt = await DeployContractAndWaitForReceiptAsync(web3, citizensDeployment, cancellationTokenSource);
            return new CitizensService(web3, receipt.ContractAddress);
        }

        protected Nethereum.Web3.Web3 Web3{ get; }

        public ContractHandler ContractHandler { get; }

        public CitizensService(Nethereum.Web3.Web3 web3, string contractAddress)
        {
            Web3 = web3;
            ContractHandler = web3.Eth.GetContractHandler(contractAddress);
        }

        public Task<bool> AllowanceQueryAsync(AllowanceFunction allowanceFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<AllowanceFunction, bool>(allowanceFunction, blockParameter);
        }

        
        public Task<bool> AllowanceQueryAsync(string claimant, BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var allowanceFunction = new AllowanceFunction();
                allowanceFunction.Claimant = claimant;
                allowanceFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<AllowanceFunction, bool>(allowanceFunction, blockParameter);
        }

        public Task<string> ApproveRequestAsync(ApproveFunction approveFunction)
        {
             return ContractHandler.SendRequestAsync(approveFunction);
        }

        public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(ApproveFunction approveFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
        }

        public Task<string> ApproveRequestAsync(string to, BigInteger tokenId)
        {
            var approveFunction = new ApproveFunction();
                approveFunction.To = to;
                approveFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(approveFunction);
        }

        public Task<TransactionReceipt> ApproveRequestAndWaitForReceiptAsync(string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var approveFunction = new ApproveFunction();
                approveFunction.To = to;
                approveFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(approveFunction, cancellationToken);
        }

        public Task<BigInteger> BalanceOfQueryAsync(BalanceOfFunction balanceOfFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        
        public Task<BigInteger> BalanceOfQueryAsync(string owner, BlockParameter blockParameter = null)
        {
            var balanceOfFunction = new BalanceOfFunction();
                balanceOfFunction.Owner = owner;
            
            return ContractHandler.QueryAsync<BalanceOfFunction, BigInteger>(balanceOfFunction, blockParameter);
        }

        public Task<string> GalleassQueryAsync(GalleassFunction galleassFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GalleassFunction, string>(galleassFunction, blockParameter);
        }

        
        public Task<string> GalleassQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GalleassFunction, string>(null, blockParameter);
        }

        public Task<string> GetContractQueryAsync(GetContractFunction getContractFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<GetContractFunction, string>(getContractFunction, blockParameter);
        }

        
        public Task<string> GetContractQueryAsync(byte[] name, BlockParameter blockParameter = null)
        {
            var getContractFunction = new GetContractFunction();
                getContractFunction.Name = name;
            
            return ContractHandler.QueryAsync<GetContractFunction, string>(getContractFunction, blockParameter);
        }

        public Task<bool> HasPermissionQueryAsync(HasPermissionFunction hasPermissionFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<HasPermissionFunction, bool>(hasPermissionFunction, blockParameter);
        }

        
        public Task<bool> HasPermissionQueryAsync(string contract, byte[] permission, BlockParameter blockParameter = null)
        {
            var hasPermissionFunction = new HasPermissionFunction();
                hasPermissionFunction.Contract = contract;
                hasPermissionFunction.Permission = permission;
            
            return ContractHandler.QueryAsync<HasPermissionFunction, bool>(hasPermissionFunction, blockParameter);
        }

        public Task<bool> IsOwnerQueryAsync(IsOwnerFunction isOwnerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsOwnerFunction, bool>(isOwnerFunction, blockParameter);
        }

        
        public Task<bool> IsOwnerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<IsOwnerFunction, bool>(null, blockParameter);
        }

        public Task<string> NameQueryAsync(NameFunction nameFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NameFunction, string>(nameFunction, blockParameter);
        }

        
        public Task<string> NameQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<NameFunction, string>(null, blockParameter);
        }

        public Task<string> OwnerQueryAsync(OwnerFunction ownerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(ownerFunction, blockParameter);
        }

        
        public Task<string> OwnerQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerFunction, string>(null, blockParameter);
        }

        public Task<string> OwnerOfQueryAsync(OwnerOfFunction ownerOfFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<OwnerOfFunction, string>(ownerOfFunction, blockParameter);
        }

        
        public Task<string> OwnerOfQueryAsync(BigInteger tokenId, BlockParameter blockParameter = null)
        {
            var ownerOfFunction = new OwnerOfFunction();
                ownerOfFunction.TokenId = tokenId;
            
            return ContractHandler.QueryAsync<OwnerOfFunction, string>(ownerOfFunction, blockParameter);
        }

        public Task<string> RenounceOwnershipRequestAsync(RenounceOwnershipFunction renounceOwnershipFunction)
        {
             return ContractHandler.SendRequestAsync(renounceOwnershipFunction);
        }

        public Task<string> RenounceOwnershipRequestAsync()
        {
             return ContractHandler.SendRequestAsync<RenounceOwnershipFunction>();
        }

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(RenounceOwnershipFunction renounceOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(renounceOwnershipFunction, cancellationToken);
        }

        public Task<TransactionReceipt> RenounceOwnershipRequestAndWaitForReceiptAsync(CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync<RenounceOwnershipFunction>(null, cancellationToken);
        }

        public Task<string> SymbolQueryAsync(SymbolFunction symbolFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SymbolFunction, string>(symbolFunction, blockParameter);
        }

        
        public Task<string> SymbolQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<SymbolFunction, string>(null, blockParameter);
        }

        public Task<string> TokenIndexToApprovedQueryAsync(TokenIndexToApprovedFunction tokenIndexToApprovedFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenIndexToApprovedFunction, string>(tokenIndexToApprovedFunction, blockParameter);
        }

        
        public Task<string> TokenIndexToApprovedQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var tokenIndexToApprovedFunction = new TokenIndexToApprovedFunction();
                tokenIndexToApprovedFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<TokenIndexToApprovedFunction, string>(tokenIndexToApprovedFunction, blockParameter);
        }

        public Task<string> TokenIndexToOwnerQueryAsync(TokenIndexToOwnerFunction tokenIndexToOwnerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokenIndexToOwnerFunction, string>(tokenIndexToOwnerFunction, blockParameter);
        }

        
        public Task<string> TokenIndexToOwnerQueryAsync(BigInteger returnValue1, BlockParameter blockParameter = null)
        {
            var tokenIndexToOwnerFunction = new TokenIndexToOwnerFunction();
                tokenIndexToOwnerFunction.ReturnValue1 = returnValue1;
            
            return ContractHandler.QueryAsync<TokenIndexToOwnerFunction, string>(tokenIndexToOwnerFunction, blockParameter);
        }

        public Task<string> TransferRequestAsync(TransferFunction transferFunction)
        {
             return ContractHandler.SendRequestAsync(transferFunction);
        }

        public Task<TransactionReceipt> TransferRequestAndWaitForReceiptAsync(TransferFunction transferFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFunction, cancellationToken);
        }

        public Task<string> TransferRequestAsync(string to, BigInteger tokenId)
        {
            var transferFunction = new TransferFunction();
                transferFunction.To = to;
                transferFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(transferFunction);
        }

        public Task<TransactionReceipt> TransferRequestAndWaitForReceiptAsync(string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var transferFunction = new TransferFunction();
                transferFunction.To = to;
                transferFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFunction, cancellationToken);
        }

        public Task<string> TransferFromRequestAsync(TransferFromFunction transferFromFunction)
        {
             return ContractHandler.SendRequestAsync(transferFromFunction);
        }

        public Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(TransferFromFunction transferFromFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
        }

        public Task<string> TransferFromRequestAsync(string from, string to, BigInteger tokenId)
        {
            var transferFromFunction = new TransferFromFunction();
                transferFromFunction.From = from;
                transferFromFunction.To = to;
                transferFromFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(transferFromFunction);
        }

        public Task<TransactionReceipt> TransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var transferFromFunction = new TransferFromFunction();
                transferFromFunction.From = from;
                transferFromFunction.To = to;
                transferFromFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferFromFunction, cancellationToken);
        }

        public Task<string> TransferOwnershipRequestAsync(TransferOwnershipFunction transferOwnershipFunction)
        {
             return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(TransferOwnershipFunction transferOwnershipFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public Task<string> TransferOwnershipRequestAsync(string newOwner)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
             return ContractHandler.SendRequestAsync(transferOwnershipFunction);
        }

        public Task<TransactionReceipt> TransferOwnershipRequestAndWaitForReceiptAsync(string newOwner, CancellationTokenSource cancellationToken = null)
        {
            var transferOwnershipFunction = new TransferOwnershipFunction();
                transferOwnershipFunction.NewOwner = newOwner;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(transferOwnershipFunction, cancellationToken);
        }

        public Task<string> UpgradeGalleassRequestAsync(UpgradeGalleassFunction upgradeGalleassFunction)
        {
             return ContractHandler.SendRequestAsync(upgradeGalleassFunction);
        }

        public Task<TransactionReceipt> UpgradeGalleassRequestAndWaitForReceiptAsync(UpgradeGalleassFunction upgradeGalleassFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(upgradeGalleassFunction, cancellationToken);
        }

        public Task<string> UpgradeGalleassRequestAsync(string galleass)
        {
            var upgradeGalleassFunction = new UpgradeGalleassFunction();
                upgradeGalleassFunction.Galleass = galleass;
            
             return ContractHandler.SendRequestAsync(upgradeGalleassFunction);
        }

        public Task<TransactionReceipt> UpgradeGalleassRequestAndWaitForReceiptAsync(string galleass, CancellationTokenSource cancellationToken = null)
        {
            var upgradeGalleassFunction = new UpgradeGalleassFunction();
                upgradeGalleassFunction.Galleass = galleass;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(upgradeGalleassFunction, cancellationToken);
        }

        public Task<string> WithdrawRequestAsync(WithdrawFunction withdrawFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawFunction);
        }

        public Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(WithdrawFunction withdrawFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawFunction, cancellationToken);
        }

        public Task<string> WithdrawRequestAsync(BigInteger amount)
        {
            var withdrawFunction = new WithdrawFunction();
                withdrawFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(withdrawFunction);
        }

        public Task<TransactionReceipt> WithdrawRequestAndWaitForReceiptAsync(BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var withdrawFunction = new WithdrawFunction();
                withdrawFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawFunction, cancellationToken);
        }

        public Task<string> WithdrawTokenRequestAsync(WithdrawTokenFunction withdrawTokenFunction)
        {
             return ContractHandler.SendRequestAsync(withdrawTokenFunction);
        }

        public Task<TransactionReceipt> WithdrawTokenRequestAndWaitForReceiptAsync(WithdrawTokenFunction withdrawTokenFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawTokenFunction, cancellationToken);
        }

        public Task<string> WithdrawTokenRequestAsync(string token, BigInteger amount)
        {
            var withdrawTokenFunction = new WithdrawTokenFunction();
                withdrawTokenFunction.Token = token;
                withdrawTokenFunction.Amount = amount;
            
             return ContractHandler.SendRequestAsync(withdrawTokenFunction);
        }

        public Task<TransactionReceipt> WithdrawTokenRequestAndWaitForReceiptAsync(string token, BigInteger amount, CancellationTokenSource cancellationToken = null)
        {
            var withdrawTokenFunction = new WithdrawTokenFunction();
                withdrawTokenFunction.Token = token;
                withdrawTokenFunction.Amount = amount;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(withdrawTokenFunction, cancellationToken);
        }

        public Task<string> GalleassetTransferFromRequestAsync(GalleassetTransferFromFunction galleassetTransferFromFunction)
        {
             return ContractHandler.SendRequestAsync(galleassetTransferFromFunction);
        }

        public Task<TransactionReceipt> GalleassetTransferFromRequestAndWaitForReceiptAsync(GalleassetTransferFromFunction galleassetTransferFromFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(galleassetTransferFromFunction, cancellationToken);
        }

        public Task<string> GalleassetTransferFromRequestAsync(string from, string to, BigInteger tokenId)
        {
            var galleassetTransferFromFunction = new GalleassetTransferFromFunction();
                galleassetTransferFromFunction.From = from;
                galleassetTransferFromFunction.To = to;
                galleassetTransferFromFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAsync(galleassetTransferFromFunction);
        }

        public Task<TransactionReceipt> GalleassetTransferFromRequestAndWaitForReceiptAsync(string from, string to, BigInteger tokenId, CancellationTokenSource cancellationToken = null)
        {
            var galleassetTransferFromFunction = new GalleassetTransferFromFunction();
                galleassetTransferFromFunction.From = from;
                galleassetTransferFromFunction.To = to;
                galleassetTransferFromFunction.TokenId = tokenId;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(galleassetTransferFromFunction, cancellationToken);
        }

        public Task<string> CreateCitizenRequestAsync(CreateCitizenFunction createCitizenFunction)
        {
             return ContractHandler.SendRequestAsync(createCitizenFunction);
        }

        public Task<TransactionReceipt> CreateCitizenRequestAndWaitForReceiptAsync(CreateCitizenFunction createCitizenFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createCitizenFunction, cancellationToken);
        }

        public Task<string> CreateCitizenRequestAsync(string owner, byte status, BigInteger data, ushort x, ushort y, byte tile, byte[] genes, byte[] characteristics)
        {
            var createCitizenFunction = new CreateCitizenFunction();
                createCitizenFunction.Owner = owner;
                createCitizenFunction.Status = status;
                createCitizenFunction.Data = data;
                createCitizenFunction.X = x;
                createCitizenFunction.Y = y;
                createCitizenFunction.Tile = tile;
                createCitizenFunction.Genes = genes;
                createCitizenFunction.Characteristics = characteristics;
            
             return ContractHandler.SendRequestAsync(createCitizenFunction);
        }

        public Task<TransactionReceipt> CreateCitizenRequestAndWaitForReceiptAsync(string owner, byte status, BigInteger data, ushort x, ushort y, byte tile, byte[] genes, byte[] characteristics, CancellationTokenSource cancellationToken = null)
        {
            var createCitizenFunction = new CreateCitizenFunction();
                createCitizenFunction.Owner = owner;
                createCitizenFunction.Status = status;
                createCitizenFunction.Data = data;
                createCitizenFunction.X = x;
                createCitizenFunction.Y = y;
                createCitizenFunction.Tile = tile;
                createCitizenFunction.Genes = genes;
                createCitizenFunction.Characteristics = characteristics;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(createCitizenFunction, cancellationToken);
        }

        public Task<string> SetStatusRequestAsync(SetStatusFunction setStatusFunction)
        {
             return ContractHandler.SendRequestAsync(setStatusFunction);
        }

        public Task<TransactionReceipt> SetStatusRequestAndWaitForReceiptAsync(SetStatusFunction setStatusFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setStatusFunction, cancellationToken);
        }

        public Task<string> SetStatusRequestAsync(BigInteger id, byte status)
        {
            var setStatusFunction = new SetStatusFunction();
                setStatusFunction.Id = id;
                setStatusFunction.Status = status;
            
             return ContractHandler.SendRequestAsync(setStatusFunction);
        }

        public Task<TransactionReceipt> SetStatusRequestAndWaitForReceiptAsync(BigInteger id, byte status, CancellationTokenSource cancellationToken = null)
        {
            var setStatusFunction = new SetStatusFunction();
                setStatusFunction.Id = id;
                setStatusFunction.Status = status;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setStatusFunction, cancellationToken);
        }

        public Task<string> SetTileRequestAsync(SetTileFunction setTileFunction)
        {
             return ContractHandler.SendRequestAsync(setTileFunction);
        }

        public Task<TransactionReceipt> SetTileRequestAndWaitForReceiptAsync(SetTileFunction setTileFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTileFunction, cancellationToken);
        }

        public Task<string> SetTileRequestAsync(BigInteger id, byte tile)
        {
            var setTileFunction = new SetTileFunction();
                setTileFunction.Id = id;
                setTileFunction.Tile = tile;
            
             return ContractHandler.SendRequestAsync(setTileFunction);
        }

        public Task<TransactionReceipt> SetTileRequestAndWaitForReceiptAsync(BigInteger id, byte tile, CancellationTokenSource cancellationToken = null)
        {
            var setTileFunction = new SetTileFunction();
                setTileFunction.Id = id;
                setTileFunction.Tile = tile;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setTileFunction, cancellationToken);
        }

        public Task<string> SetDataRequestAsync(SetDataFunction setDataFunction)
        {
             return ContractHandler.SendRequestAsync(setDataFunction);
        }

        public Task<TransactionReceipt> SetDataRequestAndWaitForReceiptAsync(SetDataFunction setDataFunction, CancellationTokenSource cancellationToken = null)
        {
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setDataFunction, cancellationToken);
        }

        public Task<string> SetDataRequestAsync(BigInteger id, BigInteger data)
        {
            var setDataFunction = new SetDataFunction();
                setDataFunction.Id = id;
                setDataFunction.Data = data;
            
             return ContractHandler.SendRequestAsync(setDataFunction);
        }

        public Task<TransactionReceipt> SetDataRequestAndWaitForReceiptAsync(BigInteger id, BigInteger data, CancellationTokenSource cancellationToken = null)
        {
            var setDataFunction = new SetDataFunction();
                setDataFunction.Id = id;
                setDataFunction.Data = data;
            
             return ContractHandler.SendRequestAndWaitForReceiptAsync(setDataFunction, cancellationToken);
        }

        public Task<BigInteger> TotalSupplyQueryAsync(TotalSupplyFunction totalSupplyFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TotalSupplyFunction, BigInteger>(totalSupplyFunction, blockParameter);
        }

        
        public Task<BigInteger> TotalSupplyQueryAsync(BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TotalSupplyFunction, BigInteger>(null, blockParameter);
        }

        public Task<GetTokenOutputDTO> GetTokenQueryAsync(GetTokenFunction getTokenFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryDeserializingToObjectAsync<GetTokenFunction, GetTokenOutputDTO>(getTokenFunction, blockParameter);
        }

        public Task<GetTokenOutputDTO> GetTokenQueryAsync(BigInteger id, BlockParameter blockParameter = null)
        {
            var getTokenFunction = new GetTokenFunction();
                getTokenFunction.Id = id;
            
            return ContractHandler.QueryDeserializingToObjectAsync<GetTokenFunction, GetTokenOutputDTO>(getTokenFunction, blockParameter);
        }

        public Task<List<BigInteger>> TokensOfOwnerQueryAsync(TokensOfOwnerFunction tokensOfOwnerFunction, BlockParameter blockParameter = null)
        {
            return ContractHandler.QueryAsync<TokensOfOwnerFunction, List<BigInteger>>(tokensOfOwnerFunction, blockParameter);
        }

        
        public Task<List<BigInteger>> TokensOfOwnerQueryAsync(string owner, BlockParameter blockParameter = null)
        {
            var tokensOfOwnerFunction = new TokensOfOwnerFunction();
                tokensOfOwnerFunction.Owner = owner;
            
            return ContractHandler.QueryAsync<TokensOfOwnerFunction, List<BigInteger>>(tokensOfOwnerFunction, blockParameter);
        }
    }
}
