using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class ShopManager : MonoBehaviour
{
    public int coins;
    public TMP_Text coinUI;
    public ShopItemSO[] shopItemSO;
    public ShopTemplate[] shopPanels;

    void Start()
    {
        coinUI.text = "Coins: " + coins.ToString();
        LoadPanels();
    }

    public void AddCoins()
    {
        coins++;
        coinUI.text = "Coins: " + coins.ToString();
        //CheckPurchaseable();
    }

    public void LoadPanels()
    {
        for (int i = 0; i < shopItemSO.Length; i++)
        {
            shopPanels[i].titleText.text = shopItemSO[i].title;
            shopPanels[i].descriptionText.text = shopItemSO[i].description;
            shopPanels[i].costTxt.text = "Coins: " + shopItemSO[i].baseCoin.ToString();
        }
    }
}
