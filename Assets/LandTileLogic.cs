using System;
using System.Collections.Generic;
using UnityEngine;

namespace Galleass3D
{
    public class LandTileLogic : MonoBehaviour
    {

        #region static
        private static readonly Dictionary<string, int> MappingNameToID = new Dictionary<string, int>();
        private static readonly Dictionary<int, string> MappingIDToName = new Dictionary<int, string>();

        static LandTileLogic()
        {
            MappingNameToID.Add("MainHills",1);
            MappingNameToID.Add("MainGrass",2);

            MappingNameToID.Add("MainStream",30);

            MappingNameToID.Add("Grass",50);
            MappingNameToID.Add("Forest",51);
            MappingNameToID.Add("Mountain",52);
            MappingNameToID.Add("CopperMountain",53);
            MappingNameToID.Add("SilverMountain",54);

            MappingNameToID.Add("Harbor",100);
            MappingNameToID.Add("Fishmonger",101);
            MappingNameToID.Add("Market",102);

            MappingNameToID.Add("TimberCamp",150);

            MappingNameToID.Add("Village",2000);


            foreach (var dictItem in MappingNameToID)
            {
                MappingIDToName.Add(dictItem.Value, dictItem.Key);
            }
        }
        #endregion

        public EthKeyManager EthKeyManager;

        [SerializeField]
        public int IslandNumber;

        public static string GetTileNameFromID(int id)
        {
            return MappingIDToName[id];
        }



        void Update()
        {

        }

    }
}
