using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    PlayerManager playerObj;
    Vector3 offset;
    Vector3 targetPos;

    void Start()
    {
        playerObj = GetComponent<PlayerManager>();
        offset = transform.position - player.position;
    }

    void Update()
    {
        if (GameObject.Find("Player") == false)
        {
            transform.position = transform.position;   return; 
        }
        targetPos = player.position + offset;
        transform.position = targetPos;
    }
}
