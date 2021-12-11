using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Dublication : MonoBehaviour
{
    public GameObject Slot;
    public List<Items> Items;
    void Start()
    {
        CallMarket();
    }

    void CallMarket()
    {
        for (int i = 0; i < Items.Count; i++)
        {
            GameObject IncreasedSlot = Instantiate(Slot, transform);
            IncreasedSlot.GetComponent<Image>().sprite = Items[i].Sprite;
            IncreasedSlot.GetComponent<TMP_Text>().text = Items[i].ShopItemName.text;
        }
    }
}

[System.Serializable]
public class Items
{
    public TMP_Text ShopItemName;
    public string Name;
    public Sprite Sprite;

    public Items(TMP_Text shopItemName, string name, Sprite sprite)
    {
        Name = name;
        Sprite = sprite;
        ShopItemName = shopItemName;
        shopItemName.text = name;
    }
}
