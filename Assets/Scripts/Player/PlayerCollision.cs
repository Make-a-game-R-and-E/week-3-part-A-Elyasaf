using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private PlayerHP playerHealth;

    private void Start()
    {
        playerHealth = GetComponent<PlayerHP>();
        if (playerHealth == null)
        {
            Debug.LogError("PlayerCollision: No PlayerHealth component found on the player.");
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            playerHealth.TakeDamage(1);
            Destroy(other.gameObject);
        }
    }

}
