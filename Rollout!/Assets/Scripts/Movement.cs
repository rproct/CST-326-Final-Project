using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        //Reduces speed if button is pressed
        if (Input.GetKeyDown(KeyCode.Space))
            speed /= 2;
        else if (Input.GetKeyUp(KeyCode.Space))
            speed *= 2;
        
        float moveVert = Input.GetAxis("Vertical");
        
        //Moves forward and backward based on camera position
        Vector3 move = new Vector3(0f, 0f, moveVert);
        Vector3 camDir = Camera.current.transform.TransformDirection(move);
        rb.AddForce(camDir.normalized * speed);
    }
    
}
