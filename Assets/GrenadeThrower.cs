//Written by Hermon
//Sat Apr 8 2023

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeThrower : MonoBehaviour
{
    // Start is called before the first frame update
    public float throwForce = 40f;
    public GameObject grenadePrefab;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            ThrowGrenade () ;
        }
    }

    void ThrowGrenade () 
    {
        GameObject grenade = Instantiate (grenadePrefab, transform.position, transform. rotation);
        Rigidbody rb = grenade. GetComponent<Rigidbody> ();
        rb. AddForce (transform. forward * throwForce ,ForceMode. VelocityChange);
    }
}
