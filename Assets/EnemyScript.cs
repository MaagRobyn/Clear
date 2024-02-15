using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    [SerializeField] private int health = 25;
    public void TakeDamage(int dmg)
    {
        health -= dmg;
        if(health <= 0)
        {
            TriggerDeath();
        }
    }

    public event EventHandler OnDeath;
    public void TriggerDeath()
    {
        OnDeathEvent();
    }
    protected virtual void OnDeathEvent()
    {
        OnDeath?.Invoke(this, EventArgs.Empty);
    }
}
