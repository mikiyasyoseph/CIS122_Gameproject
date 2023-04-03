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
        var enemyControl = GetComponent<EnemyController>();
        enemyControl.playDead();
        Destroy(gameObject, 2.0f);
    }
    public override void InitVariables()
    {
        maxHealth = 100;
        SetHealthTo(maxHealth);
    }
    public int getHealth()
    {
        return base.Health;
    }
}
