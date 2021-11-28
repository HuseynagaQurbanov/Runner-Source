using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    void FixedUpdate()
    {
        gameObject.transform.Rotate(new Vector3(0f,0f, -3.5f));
    }
}
