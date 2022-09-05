using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private float playerYPos;

    void Start()
    {
        playerYPos = transform.position.y;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //position switch
            playerYPos = -playerYPos;

            transform.position = new Vector3(transform.position.x, playerYPos, transform.position.z);
        }
    }
}
