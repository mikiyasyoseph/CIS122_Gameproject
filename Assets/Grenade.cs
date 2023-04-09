//Written by Hermon
//Sat Apr 8 2023

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Grenade : MonoBehaviour
{
    [SerializeField] GameObject explosionEffect;


    [SerializeField] float delay = 3f;
    public float radius = 5f;
    [SerializeField] float force = 700f;


    float countdown;
    bool hasExploded = false;

    // Start is called before the first frame update
    void Start()
    {
        countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;
        if(countdown <= 0f && hasExploded == false )
        {
            Explode();
            hasExploded = true;
        }
    }
    void Explode()
    {
        Instantiate (explosionEffect, transform.position, transform. rotation);

        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject. GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb. AddExplosionForce (force, transform.position, radius) ;
            }
        }

        
        
        Destroy (gameObject);

    }
    
}
