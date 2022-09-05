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
        if (GameManager.instance.gameStarted)
        {
            if (Input.GetMouseButtonDown(0))
            {
                PositionSwitch();
            }
        }
    }

    private void PositionSwitch()
    {
        //position switch
        playerYPos = -playerYPos;

        transform.position = new Vector3(transform.position.x, playerYPos, transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Obstacles")
        {
            GameManager.instance.UpdateLives();
        }
    }
}
