using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 100; // Maximum health of the object
    private int currentHealth; // Current health of the object

    // Start is called before the first frame update
    void Start()
    {
        // Initialize current health to max health
        currentHealth = maxHealth;
    }

    // Method to take damage
    public void TakeDamage(int damageAmount)
    {
        // Subtract damage from current health
        currentHealth -= damageAmount;

        // Check if current health is less than or equal to 0
        if (currentHealth <= 0)
        {
            Die(); // Call Die method if health is depleted
        }
    }

    // Method to handle death
    void Die()
    {
        // Perform any actions related to death (e.g., play death animation, deactivate object, etc.)
        Destroy(gameObject); // Destroy the GameObject when it dies
    }
}
