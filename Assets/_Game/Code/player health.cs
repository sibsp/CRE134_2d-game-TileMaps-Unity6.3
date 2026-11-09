using UnityEngine;

public class playerhealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int health;

    void Start()
    {
        health = maxHealth;
    }
public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
    void Die()
    {
        // Handle player death here
        Debug.Log("Player has died.");
    }
}
