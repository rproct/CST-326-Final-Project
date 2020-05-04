using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GunMovement : MonoBehaviour
{
    private HingeJoint hj;
    private JointSpring js;
    private Rigidbody rb;

    private void Start()
    {
        hj = GetComponent<HingeJoint>();
        rb = GetComponent<Rigidbody>();
        
        //Constrains the hinge joint from -60 to 60 deg
        JointLimits limits = hj.limits;
        limits.min = -60;
        limits.max = 60;
        limits.bounciness = 0;
        limits.bounceMinVelocity = 0;
        hj.limits = limits;
    }

    private void FixedUpdate()
    {
        //Restricts Rotation of the Rigidbody
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
        //Rotates Rigidbody based on mouse movement
        Quaternion delta = Quaternion.Euler(-Input.GetAxis("Mouse Y"), 0, 0);
        rb.MoveRotation(rb.rotation * delta);
    }

    // public float speed = 10f;
    // public Vector3 targetPos;
    // public bool isMoving;
    // const int MOUSE = 0;
//
    // void Start()
    // {
    //     targetPos = transform.position;
    //     isMoving = false;
    // }
    //
    // void Update()
    // {
    //     if(Input.GetMouseButton(MOUSE))
    //     {
    //         SetTargetPosition();
    //     }
    //
    //     if(isMoving)
    //     {
    //         MoveObject();
    //     }
    // }
    //
    // void SetTargetPosition()
    // {
    //     Plane plane = new Plane(Vector3.up, transform.position);
    //     Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //     float point = 0f;
    //
    //     if(plane.Raycast(ray, out point))
    //         targetPos = ray.GetPoint(point);
    //
    //     isMoving = true;
    // }
    //
    // void MoveObject()
    // {
    //     transform.LookAt(targetPos);
    //     transform.position = Vector3.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    //
    //     if(transform.position == targetPos)
    //         isMoving = false;
    // }
}