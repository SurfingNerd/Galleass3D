using System;
using System.Collections;
using System.Collections.Generic;
using Galleass3D;
using Galleass3D.Contracts.Land.ContractDefinition;
using UnityEngine;
using UnityEngine.UI;

public class LandTileDialoge : MonoBehaviour
{
    Text OwnerText;
    Text TypeText;
    Text BuyAmountText;
    Button BuyButton;
    LandManager LandManager;



    public void SetLandManager(LandManager landManager)
    {
        LandManager = landManager;
    }

    // Start is called before the first frame update
    void Start()
    {

        //Debug.LogWarning(transform.name);

        //LandTileDialoge
        Transform childTransform = transform.GetChild(0);

        if (childTransform != null)
        {
            Debug.LogWarning(childTransform.name +  " found.");
        }

        if (childTransform.Find("OwnerText") != null)
        {
            Debug.LogWarning("OwnerText found");
        }

        OwnerText = childTransform.Find("OwnerText").GetComponent<Text>();
        TypeText = childTransform.Find("TypeText").GetComponent<Text>();
        BuyButton = childTransform.Find("BuyButton").GetComponent<Button>();

        BuyAmountText = BuyButton.GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    internal void Show(GetTileOutputDTO getTileOutputDTO)
    {

        OwnerText.text = getTileOutputDTO.Owner;
        TypeText.text = LandManager.MappingIDToName[getTileOutputDTO.Tile];


        BuyAmountText.IsActive();
        BuyAmountText.text = "Buy for " + getTileOutputDTO.Price.ToString();

        //Debug.LogWarning("Child: " + transform.GetChild(0).name + " " + (transform.GetChild(0).name == "LandTileDialoge"));
        transform.GetChild(0).gameObject.SetActive(true);

        //transform.gameObject.FindRecursiveByName("LandTileDialoge").SetActive(true);
        //transform.Find("LandTileDialoge").gameObject.SetActive(true); ;
    }
}
