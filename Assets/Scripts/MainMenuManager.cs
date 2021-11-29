using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    GameObject shop;
    GameObject levelSelect;
    GameObject mainMenu;


    void Start()
    {
        shop = GameObject.Find("ShopScreen");
        levelSelect = GameObject.Find("LevelSelect");
        mainMenu = GameObject.Find("MainMenu");
        shop.SetActive(false);
        levelSelect.SetActive(false);
        mainMenu.SetActive(true);
    }
    public void Play()
    {
        mainMenu.SetActive(false);
        levelSelect.SetActive(true);
    }
    public void Shop()
    {
        mainMenu.SetActive(false);
        shop.SetActive(true);
    }

    public void ShopBack()
    {
        shop.SetActive(false);
        mainMenu.SetActive(true);
    }
}
