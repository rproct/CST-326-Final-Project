using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //The bullet will destroy itself if it makes contact
    private void OnCollisionEnter(Collision other)
    {
        Destroy(gameObject);
    }
}
