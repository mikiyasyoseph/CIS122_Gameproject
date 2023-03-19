// Written by Hemron
// Sat Mar 11 2023

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [Header ("References") ]
    [SerializeField] GunData gunData; 
    [SerializeField] Transform muzzle;

    float timeSinceLastShot;

    public void StartReload() 
    {
        if (!gunData.reloading) 
        {
            // reload
            StartCoroutine (Reload());
        }
    }
    private IEnumerator Reload() 
    {
        gunData.reloading = true;
        
        yield return new WaitForSeconds (gunData.reloadTime) ;
        
        gunData.currentAmmo = gunData. magSize;
        
        gunData. reloading = false;
    }

    private bool CanShoot () => !gunData. reloading && timeSinceLastShot > 1f / (gunData. fireRate / 60f);

    public void Shoot()
    {
        if (gunData. currentAmmo > 0)
        {
            if (CanShoot ( ))
            {
                if (Physics.Raycast (muzzle.position, transform. forward, out RaycastHit hitInfo, gunData.maxDistance))
                {
                    IDamageable damageable = hitInfo. transform. GetComponent<IDamageable> () ;
                    damageable?. TakeDamage (gunData. damage);
                }
                gunData. currentAmmo--;
                timeSinceLastShot = 0;
                OnGunShot () ;
            }
        }
    }
    public void OnGunShot()
    {
        
    }
    private void Awake()
    {
        //make sure magazine is full
        gunData.currentAmmo = gunData. magSize;
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayerShoot. shootInput += Shoot;
        PlayerShoot .reloadInput += StartReload;
    }

    void Update()
    {
        timeSinceLastShot += Time. deltaTime;

        Debug. DrawRay (muzzle.position, muzzle.forward);
    }
}
