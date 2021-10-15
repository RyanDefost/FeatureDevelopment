using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour
{
    private float _currentHealth;
    public float CurrentHealth { get { return _currentHealth; } }

    [SerializeField] private float _startHealth;

    private void Awake()
    {
        _currentHealth = _startHealth;
    }

    public void TakenDamage(float amount)
    {
        _currentHealth -= amount;

        HandelTakeDamage();

        if (_currentHealth <= 0)
        {
            Death();
        }
    }

    public float GetNormalizedHealth()
    {
        return 0; 
    }

    protected virtual void HandelTakeDamage()
    {
        Debug.Log("ik krijg damage");

    }

    protected virtual void Death()
    {
        Debug.Log("Ik ben dood");
    }
}
