using UnityEngine;

public class TargetForElevator : MonoBehaviour
{
    public float health = 1f;
    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
