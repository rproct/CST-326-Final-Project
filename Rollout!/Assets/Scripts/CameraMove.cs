using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Camera cam1;
    [SerializeField] private Camera cam2;

    private void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
    }

    private void LateUpdate()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cam1.enabled = false;
            cam2.enabled = true;
        }

        if (Input.GetKeyUp(KeyCode.Space))
        {
            cam1.enabled = true;
            cam2.enabled = false;
        }
    }
}
