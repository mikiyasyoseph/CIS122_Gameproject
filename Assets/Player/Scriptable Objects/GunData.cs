// Written by Hemron
// Sat Mar 11 2023

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="Gun", menuName="Weapon/Gun")]

// The following code defines a class called GunData which derives from Unity's ScriptableObject class.
public class GunData : ScriptableObject 
{
    // public fields that store data related to a gun's attributes:

    [Header("Info")]
    public new string name;

    [Header("Shooting")]
    public float damage;
    public float maxDistance;
    
    [Header("Reloading")]
    public int currentAmmo;
    public int magSize;
    [Tooltip("In RPM")] public float fireRate;
    public float reloadTime;
    [HideInInspector] public bool reloading;
    
}
