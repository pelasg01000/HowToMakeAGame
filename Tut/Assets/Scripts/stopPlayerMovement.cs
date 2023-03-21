using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopPlayerMovement : MonoBehaviour
{
    public PlayerMovement movement;
    public GameManager gamemanager;

    private void Start()
    {
        gamemanager = FindObjectOfType<GameManager>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            movement.enabled = false;
            gamemanager.EndGame();
        }
    }
}
