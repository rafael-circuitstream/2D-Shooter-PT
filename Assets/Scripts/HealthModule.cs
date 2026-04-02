using UnityEngine;

public class HealthModule
{
    private float maxHealth;
    public float currentHealth;

    public void DecreaseHealth(float valueToDecrease)
    {
        currentHealth -= valueToDecrease;
        
    }

    public void IncreaseHealth(float valueToIncrease)
    {
        currentHealth += valueToIncrease;
    }

    public void Die()
    {

    }

    public HealthModule(float initialHealth)
    {
        Debug.Log("Creating health pack");
        
        maxHealth = initialHealth;
        currentHealth = maxHealth;
    }
}
