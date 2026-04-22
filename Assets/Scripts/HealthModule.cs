using System;
using UnityEngine;

public class HealthModule
{
    private float maxHealth;
    private float currentHealth;
    
    public Action OnHealthZero;

    public void DecreaseHealth(float valueToDecrease)
    {
        currentHealth -= valueToDecrease;

        

        if(currentHealth <= 0)
        {
            Die();
        }
        
    }

    public void IncreaseHealth(float valueToIncrease)
    {
        currentHealth += valueToIncrease;
    }

    public void Die()
    {
        OnHealthZero.Invoke();
    }

    public float GetCurrentHealth()
    {
        return currentHealth;
    }

    public HealthModule(float initialHealth)
    {   
        maxHealth = initialHealth;
        currentHealth = maxHealth;
    }
}
