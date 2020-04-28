using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateChair : MonoBehaviour
{
    public float speed;
    private Transform t;

    //This script rotates the chair and cameras on Y-axis
    
    private void Start()
    {
        t = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal") * speed;
        t.Rotate(0.0f, horizontal, 0.0f);
    }
}
