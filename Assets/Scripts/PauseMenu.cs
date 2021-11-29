using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu;
    public GameObject sureR;
    public GameObject sureM;

    void Start()
    {
        pauseMenu.SetActive(false);
        sureR.SetActive(false);
        sureM.SetActive(false);
    }

    public void Pause()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0;
    }

    public void Resume()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
    }

    public void AreYouSureRes()
    {
        sureR.SetActive(true);
        pauseMenu.SetActive(false);
    }
    public void AreYouSureMenu()
    {
        sureM.SetActive(true);
        pauseMenu.SetActive(false);
    }

    public void YesRestart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void YesMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void No()
    {
        sureR.SetActive(false);
        sureM.SetActive(false);
        pauseMenu.SetActive(true);
    }
}
