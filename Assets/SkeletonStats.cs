using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonStats : EnemyStats
{
    [SerializeField] private float damage;
    [SerializeField] private float attackSpeed;

    [SerializeField] private bool canAttack;

    public void DeadDamage()
    {
        //attacking feature
    }
    public override void Die()
    {
        base.Die();
        Destroy(gameObject);
    }
    public override void InitVariables()
    {
        maxHealth = 50;
        SetHealthTo(maxHealth);
    }
}
