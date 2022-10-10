using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float playerMovementSpeed = 200f;

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("w"))
        {
            rb.AddForce(0, 0, playerMovementSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }   

        if(Input.GetKey("d"))
        {
            rb.AddForce(playerMovementSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("a"))
        {
            rb.AddForce(-playerMovementSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -playerMovementSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }


    }
}
