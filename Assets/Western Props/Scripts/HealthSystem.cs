//Niftalem Kassa
//3/10/2023

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
//This code is a common class used by many other scripts for healthSystems.
public class HealthSystem
{
    public event EventHandler OnDead;

    private int health;

    public HealthSystem (int health)
    {
        this.health = health;
    }
    public int GetHealth()
    {
        return health;
    }

    public void Damage(int damageAmount)
    {
        health -= damageAmount;
    }
   public void Heal(int healAmount)
    {
        health += healAmount;
    }
}