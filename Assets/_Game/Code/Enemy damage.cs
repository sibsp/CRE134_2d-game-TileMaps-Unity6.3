using UnityEngine;

public class Enemydamage : MonoBehaviour
{
    public int damage;
    public playerhealth playerHealth;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerHealth.TakeDamage(damage);
        }
    }
}