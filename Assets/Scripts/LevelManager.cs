using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class LevelManager : MonoBehaviour
{
    public Button lvl1_Btn, lvl2_Btn, lvl3_Btn;
    public static bool lvl1, lvl2, lvl3;
    void Start()
    {
        lvl1 = true;
    }

    void Update()
    {
        CheckLevel();
    }

    #region Level Load System

    void CheckLevel() 
    {
        if (lvl2 == true)
        {
            lvl2_Btn.interactable = true;
        }
        if (lvl3 == true)
        {
            lvl3_Btn.interactable = true;
        }
    }
    public void LoadLvl1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void LoadLvl2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void LoadLvl3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    #endregion

}
