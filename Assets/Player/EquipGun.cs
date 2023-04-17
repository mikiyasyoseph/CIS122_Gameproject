// Written by Hermon
// Mon Apr 17 2023

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EquipGun : MonoBehaviour
{
    [SerializeField] GameObject inventory;
    
    [SerializeField] GameObject[] weapons;
    
    GameObject currentGun;

    // Start is called before the first frame update
    void Start()
    {
        inventory.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input. GetKeyDown (KeyCode. Tab))
        {
            inventory.SetActive(true);
        }
        else if(Input. GetKeyUp(KeyCode. Tab)) 
        {
            inventory.SetActive (false);
        }
    }
    public void SelectWeapon (int choice)
    {
        if (currentGun != null)
        {
            currentGun. SetActive (false);
        }
        currentGun = weapons [choice];
        currentGun. SetActive (true);
    }

}
