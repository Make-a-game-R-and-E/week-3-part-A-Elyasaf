using UnityEngine;

/**
 * This component increases the player's health when collected.
 */
public class HealthPickup : MonoBehaviour
{
    [Tooltip("Amount of health to restore")]
    [SerializeField] int healthAmount = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerHP playerHealth = other.GetComponent<PlayerHP>();
            if (playerHealth != null)
            {
                playerHealth.Heal(healthAmount);
            }

            // Destroy the health pickup
            Destroy(gameObject);
        }
    }
}
