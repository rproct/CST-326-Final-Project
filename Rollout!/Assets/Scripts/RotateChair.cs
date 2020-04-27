using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateChair : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Rotate(0.0f, Input.GetAxis("Horizontal") * speed, 0.0f);
    }
}
