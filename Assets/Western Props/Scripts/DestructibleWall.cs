using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleWall : MonoBehaviour, IDamagable
{
    [SerializeField] private Transform pfWallBroken;

    private HealthSystem healthSystem;
    private Vector3 lastDamagePosition;

    private void Awake()
    {
        healthSystem = new HealthSystem(100);
        healthSystem.OnDead += HealthSystem_OnDead;
    }

    private void HealthSystem_OnDead(object sender, System.EventArgs e)
    {
        Transform wallBrokenTransform = Instantiate(pfWallBroken, transform.position, transform.rotation);
        Destroy(gameObject);
        Debug.Log("Destroyed!");
    }
    public void Damage(int damageAmount, Vector3 damagePosition)
    {
        healthSystem.Damage(damageAmount);
    }
}
