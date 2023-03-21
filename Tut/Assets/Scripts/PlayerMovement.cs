using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public GameManager gamemanager;

    public float forceNumber;
    public float forceRight;
    public float forceLeft;
    private void Start()
    {
        gamemanager = FindObjectOfType<GameManager>();
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forceNumber * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(forceRight * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(forceLeft * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("g"))
        {
            rb.AddForce(0, 400 * Time.deltaTime, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < -2f)
        {
            gamemanager.EndGame();
        }
    }
}
