using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Camera cam1;
    [SerializeField] private Camera cam2;
    private Camera currentCam;
    private float viewRange = 60f;
    private float roty = 0f;

    //Sets the current camera to the front camera 
    private void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
        currentCam = cam1;
    }

    private void LateUpdate()
    {
        //Swaps to the back camera when button is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cam1.enabled = false;
            cam2.enabled = true;
            currentCam = cam2;
        }
        
        //Swaps to the front camera when button is released
        if (Input.GetKeyUp(KeyCode.Space))
        {
            cam1.enabled = true;
            cam2.enabled = false;
            currentCam = cam1;
        }
        
        //Rotates camera on X-axis
        roty += Input.GetAxis("Mouse Y");
        roty = Mathf.Clamp(roty, -1 * viewRange, viewRange);

        Transform c = currentCam.transform;
        c.eulerAngles = new Vector3(roty, c.eulerAngles.y, c.eulerAngles.z);
    }
}
