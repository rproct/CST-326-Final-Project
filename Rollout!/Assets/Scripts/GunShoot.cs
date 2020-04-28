using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShoot : MonoBehaviour
{
    public float speed;

    public Rigidbody bullet;
    

    // Update is called once per frame
    void Update()
    {
        //Shoots on Left Mouse click
        if(Input.GetKeyDown(KeyCode.Mouse0))
            Fire();
    }

    void Fire()
    {
        Rigidbody firedBullet = (Rigidbody) Instantiate(bullet, transform.position, transform.rotation);
        firedBullet.velocity = transform.forward * speed;
    }
}
