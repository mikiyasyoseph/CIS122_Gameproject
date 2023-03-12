// Written by Hemron
// Sat Mar 11 2023

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [Header ("References") ]
    [SerializeField] GunData gunData; 
    [SerializeField] Transform muzzle;

    float timeSinceLastShot;

    private bool CanShoot () => !gunData. reloading && timeSinceLastShot > 1f / (gunData. fireRate / 60f);

    public void Shoot()
    {
        if (gunData. currentAmmo > 0)
        {
            if (CanShoot ( ))
            {
                if (Physics.Raycast (muzzle.position, transform. forward, out RaycastHit hitInfo, gunData.maxDistance))
                {
                    Debug. Log (hitInfo. transform. name) ;
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

    // Start is called before the first frame update
    void Start()
    {
        PlayerShoot. shootInput += Shoot;
    }

    void Update()
    {
        timeSinceLastShot += Time. deltaTime;

        Debug. DrawRay (muzzle.position, muzzle.forward);
    }
}
