using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHP : MonoBehaviour
{
    [SerializeField]
    [Tooltip("Maximum amount of player HP")]
    int maxHP = 3;

    [SerializeField]
    [Tooltip("Current amount of player HP")]
    int currentHP;

    [SerializeField]
    [Tooltip("Name of scene to move to when triggering the given tag")]
    string sceneName;

    [SerializeField]
    [Tooltip("Reference to the UI script that displays the player's health")]
    HealthUI healthUI;


    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;

        healthUI = FindAnyObjectByType<HealthUI>();

        if (healthUI != null) { healthUI.SetHealth(currentHP); } // Update health UI
    }

    // Method to take damage
    public void TakeDamage(int damage)
    {
        if (damage <= 0) return;
        currentHP -= damage;
        if (healthUI != null) { healthUI.SetHealth(currentHP); } // Update health UI
        if (currentHP <= 0)
        {
            currentHP = 0;
            Die(); // Trigger death if HP drops to zero
        }
    }

    // Method to heal
    public void Heal(int healAmount)
    {
        if (healAmount <= 0) return;
        currentHP += healAmount;
        if (healthUI != null) { healthUI.SetHealth(currentHP); } // Update health UI
        if (currentHP > maxHP)
        {
            currentHP = maxHP;
        }
    }

    // Method to set HP explicitly (e.g., for respawn or power-ups)
    public void SetHP(int newHP)
    {
        currentHP = Mathf.Clamp(newHP, 0, maxHP);
    }


    // Trigger actions when the player dies
    private void Die()
    {
        Debug.Log($"{gameObject.name} has died.");
        // sent the player to "game over" screen.
        SceneManager.LoadScene(sceneName);
    }

    // Getters for currentHP and maxHP
    public int GetCurrentHP() => currentHP;
    public int GetMaxHP() => maxHP;
}
