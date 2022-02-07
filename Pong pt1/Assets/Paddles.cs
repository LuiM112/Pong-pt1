using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum ePLayer
{
    Left,
    
    Right,
}

public class Paddles : MonoBehaviour
{
    //player speed 

    public float movementPerSecond = 15f;

    public ePLayer player;

    // Update is called once per frame
    void Update()
    {
        float speed = 0f;

        if (player == ePLayer.Left)
        {
            speed = Input.GetAxisRaw("PlayerLeft");
        }
        else if (player == ePLayer.Right)
        {
            speed = Input.GetAxisRaw("PlayerRight");
        }

        transform.position += new Vector3(0f, 0f, speed * movementPerSecond * Time.deltaTime);
    }
}
