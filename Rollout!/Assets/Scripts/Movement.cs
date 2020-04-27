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
        float moveVert = Input.GetAxis("Vertical");
        
        Vector3 move = new Vector3(0f, 0f, moveVert);

        rb.AddForce(move * speed);
    }
}
