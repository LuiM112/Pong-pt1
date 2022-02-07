using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum net
{
    Left,
    Right,
}

public class Goals : MonoBehaviour
{
    public Score score;
    public net player;
    private void OnTriggerEnter(Collider other)
    {
        Ball ball = other.gameObject.GetComponent<Ball>();
        if (ball != null)
        {
            ball.transform.position = new Vector3(-10f, 1f, 0f);

            if (player == net.Left)
            {
                score.scorePlayerRight++;
                Debug.Log("Player Right has Score! "+ " Score is: " + score.scorePlayerLeft + " to " + score.scorePlayerRight);
            }
            else if (player == net.Right)
            {
                score.scorePlayerLeft++;
                Debug.Log("Player Left has Score! "+ " Score is: " + score.scorePlayerLeft + " to " + score.scorePlayerRight);
            }

            if (score.scorePlayerLeft == 11)
            {
                Debug.Log("GAME OVER! PLAYER LEFT HAS WON!");
                score.scorePlayerLeft = 0;
                score.scorePlayerRight = 0;
            }
            else if (score.scorePlayerRight == 11)
            {
                Debug.Log("GAME OVER! PLAYER RIGHT HAS WON!");
                score.scorePlayerLeft = 0;
                score.scorePlayerRight = 0;
            }
        }
    }
}
