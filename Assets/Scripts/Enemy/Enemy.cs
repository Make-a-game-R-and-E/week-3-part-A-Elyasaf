using UnityEngine;

/**
 * Base class for all enemy types.
 */
public class Enemy : MonoBehaviour
{
    [Header("Enemy Settings")]
    [SerializeField] protected int health = 1;
    [SerializeField] protected int damage = 1;
    [SerializeField] protected int scoreValue = 1;

    protected NumberField scoreField;

    protected virtual void Start()
    {
        scoreField = FindObjectOfType<NumberField>();
    }

    // Method called when the enemy takes damage
    public virtual void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    // Method called when the enemy dies
    protected virtual void Die()
    {
        // Increase score
        if (scoreField != null)
        {
            scoreField.AddNumber(scoreValue);
        }

        // Destroy the enemy GameObject
        Destroy(gameObject);
    }
}
