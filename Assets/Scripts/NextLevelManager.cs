using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevelManager : MonoBehaviour
{
    public void lvl1Finish()
    {
        LevelManager.lvl2 = true;
    }
    public void lvl2Finish()
    {
        LevelManager.lvl3 = true;
    }

    public void LoadComingSoon()
    {
        SceneManager.LoadScene("ComingSoon");
    }
}
