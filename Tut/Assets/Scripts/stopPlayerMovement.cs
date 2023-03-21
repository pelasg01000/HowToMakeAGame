using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopPlayerMovement : MonoBehaviour
{
    public PlayerMovement movement;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Obstacle")
        {
            movement.enabled = false;
        }
    }
}
