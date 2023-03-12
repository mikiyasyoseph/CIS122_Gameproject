using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructibleWall : MonoBehaviour, IDamagable
{
    [SerializeField] private Transform pfWallBroken;
    //[SerializeField] private Transform vfxSmoke;
    [SerializeField] private int healthAmountMax = 100;
    [SerializeField] private float explosionForce = 13;
   

    public HealthSystem healthSystem;
    private Vector3 lastDamagePosition;

    void Update()
    {
        if (Input.GetKeyDown("j"))
        {
            healthSystem.Damage(20);
            Debug.Log(healthSystem.GetHealth());
        }
    }
    private void Awake()
    {
        healthSystem = new HealthSystem(100);
        healthSystem.OnDead += HealthSystem_OnDead;
    }
    //This code shows what happens when exploded or dead
    private void HealthSystem_OnDead(object sender, System.EventArgs e)
    {
        //Instantiate(/*vfxSmoke,*/lastDamagePosition,Quaternion.identity);  
        Transform wallBrokenTransform = Instantiate(pfWallBroken, transform.position, transform.rotation);
        foreach (Transform child in wallBrokenTransform)
        {
            if (child.TryGetComponent<Rigidbody>(out Rigidbody childRigidbody))
            {
                childRigidbody.AddExplosionForce(100f, lastDamagePosition, 5f);
            }
        }
        Destroy(gameObject);
        Debug.Log("Destroyed!");
    }
    public void Damage(int damageAmount)//, Vector3 damagePosition)
    {
        healthSystem.Damage(damageAmount);
    }
    
}
