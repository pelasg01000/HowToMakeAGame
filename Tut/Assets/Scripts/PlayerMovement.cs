using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forceNumber;
 
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forceNumber * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(1000 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-1000 * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("g"))
        {
            rb.AddForce(0, 400 * Time.deltaTime, 0);
        }
    }
}
