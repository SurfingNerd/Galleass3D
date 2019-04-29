using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Galleass3D;
using UnityEngine;
using System.Linq;


namespace Galleass3D
{
    public class LandDetails
    {
        public int Y;
        public int X;
        public List<Galleass3D.Contracts.Land.ContractDefinition.GetTileOutputDTO> TileInfoRaw = new List<Contracts.Land.ContractDefinition.GetTileOutputDTO>();
    }

    public class LandManager : MonoBehaviour
    {
        EthKeyManager EthKeyManager;

        int CurrentShownLandX = -1;
        int CurrentShownLandY = -1;

        LandDetails CurrentLandDetails;
        bool CurrentLandDetailsDirty = false;

        List<LandTileLogic> LandTileLogics;

        // Start is called before the first frame update
        void Start()
        {
            EthKeyManager = GetComponent<EthKeyManager>();

            //NOTE: this works if everything is setup correct.
            LandTileLogic[] landTileLogics = GetComponentsInChildren<LandTileLogic>();
            LandTileLogics =landTileLogics.OrderBy(x => x.IslandNumber).ToList();

            if (LandTileLogics.Count != 18)
            {
                Debug.LogError("Expected to have 18 LandTileLogics as children!");
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (CurrentLandDetails != null)
            {
                if (CurrentLandDetailsDirty)
                {
                    Debug.LogWarning("LandTileLogics:" + LandTileLogics.Count);
                    Debug.LogWarning("CurrentLandDetails:" + CurrentLandDetails.TileInfoRaw.Count);
                    for (int i = 0; i < 18; i++)
                    {
                        LandTileLogics[i].SetTileInfo(CurrentLandDetails.TileInfoRaw[i], CurrentLandDetails.X, CurrentLandDetails.Y);
                    }
                    CurrentLandDetailsDirty = false;
                }
            }
        }

        public async void NotifyLandGeneratedEvent(Galleass3D.Contracts.Land.ContractDefinition.LandGeneratedEventDTO generateLandEvent)
        {
            await SetToNewLand(generateLandEvent);
        }

        async Task SetToNewLand(Galleass3D.Contracts.Land.ContractDefinition.LandGeneratedEventDTO generateLandEvent)
        {
            Debug.Log("Land got generated: " + generateLandEvent.X + " " + generateLandEvent.Y + " - " + generateLandEvent.Island1 + " - " + generateLandEvent.Island2 + " - " + generateLandEvent.Island3 + " - " + generateLandEvent.Island4 + " - " + generateLandEvent.Island5 + " - " + generateLandEvent.Island6 + " - " + generateLandEvent.Island7 + " - " + generateLandEvent.Island8 + " - " + generateLandEvent.Island9);
            CurrentLandDetails = await GetLandDetails(generateLandEvent.X, generateLandEvent.Y);
            CurrentLandDetailsDirty = true;
        }

        async Task<LandDetails> GetLandDetails(ushort x, ushort y)
        {
            LandDetails result = new LandDetails() { X = x, Y = y };

            //System.Threading.Thread.Sleep(5000);
            //StringBuilder sb = new StringBuilder();
            for (byte i = 0; i < 18; i++)
            {
                //EthKeyManager.Land.ContractHandler.EthApiContractService.
                //var tileOutput = await EthKeyManager.Land.GetTileQueryAsync(new Contracts.Land.ContractDefinition.GetTileFunction() { Gas = EthKeyManager.DefaultGas, GasPrice = EthKeyManager.DefaultGasPrice, X = x, Y = y, Index = i});
                var tileOutput = await EthKeyManager.Land.GetTileQueryAsync(x, y, i);

                result.TileInfoRaw.Add(tileOutput);
            }
            return result;
        }

        //public void NotifyLandChanges()
    }

}