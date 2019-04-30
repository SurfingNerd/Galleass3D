using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;

namespace Galleass3D
{
    public class LandTileLogic : MonoBehaviour
    {
        private EthKeyManager EthKeyManager;
        private LandManager LandManager;
        public Galleass3D.Contracts.Land.ContractDefinition.GetTileOutputDTO TileInfo;
        private int LandX;
        private int LandY;

        private UnityEngine.TextMesh Text;
        private UnityEngine.Terrain Terrain;

        [SerializeField]
        public int IslandNumber;

        public static string GetTileNameFromID(int id)
        {
            return LandManager.MappingIDToName[id];
        }

        public void SetTileInfo(Galleass3D.Contracts.Land.ContractDefinition.GetTileOutputDTO tileInfo, int landX, int landY)
        {
            TileInfo = tileInfo;
            LandX = landX;
            LandY = landY;

            // TileInfo.Tile
            string islandType = "Unknown " + TileInfo.Tile.ToString();

            if (LandManager.MappingIDToName.ContainsKey(TileInfo.Tile))
            {
                islandType = LandManager.MappingIDToName[TileInfo.Tile];

            }

            Text.text = islandType;

            bool showTile = (TileInfo.Tile != 0);
            Terrain.gameObject.SetActive(showTile);
            Text.gameObject.SetActive(showTile);
        }

        void Start()
        {
            EthKeyManager = GetComponentInParent<EthKeyManager>();
            LandManager = GetComponentInParent<LandManager>();

            Text = GetComponentInChildren<TextMesh>();
            Terrain = GetComponentInChildren<Terrain>();

            Text.gameObject.SetActive(false);
            Terrain.gameObject.SetActive(false);
        }

        void Update()
        {

        }

        public void BuyTile()
        {

        }

        public void MakeTileHarbor()
        {
            EditTile("Harbor");
        }

        public void EditTile(string tileTypeName)
        {
            Debug.LogWarning("EditTile" + tileTypeName);
            EthKeyManager.Land.EditTileRequestAndWaitForReceiptAsync(new Contracts.Land.ContractDefinition.EditTileFunction()
            {
                X = (ushort)LandX,
                Y = (ushort)LandY,
                Tile = (byte)IslandNumber,
                Update = (ushort)LandManager.MappingNameToID[tileTypeName],
                Contract = EthKeyManager.GetContractAddress(tileTypeName)
            });
            Debug.Log("EditTile Sent!! " + tileTypeName);
        }

        public void ShowLandTileDialoge()
        {
            //LandManager.ShowDialoge(LandX, LandY, IslandNumber);
            LandManager.ShowDialoge(this);
        }
    }
}
