using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopManager : MonoBehaviour
{
    public void IncreaseSpeed()
    {
        PlayerManager.forwardSpeed += 1;
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }

}
