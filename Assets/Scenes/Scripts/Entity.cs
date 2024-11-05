using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Events;

public class Entity : MonoBehaviour
{
    [Serializable]
    
    public struct EntityStats
    {
        public float MaxHealth;
        public float MovementSpeed;
    }

    private void Start()
    {
        CurrentHealth = stats.MaxHealth;
    }
    public EntityStats stats;

    [NonSerialized]
    public float CurrentHealth;

    bool dead = false;
    public void TakeDamage(float damage)
    {
        if (dead) return;

        CurrentHealth -= Mathf.Ceil(damage);

        if (CurrentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        dead = true;
        Destroy(gameObject);
    }
}