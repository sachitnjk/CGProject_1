using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int MaxHealth = 3;
    public int CurrentHealth;

    // Restarting player health on game start
    void Start()
    {
      CurrentHealth = MaxHealth;
    }

    // Checking player health
    void Update()
    {
        if (CurrentHealth <= 0);
        {
            CurrentHealth = 0;
            //player death
        }
        if (CurrentHealth >= MaxHealth);
        {
            CurrentHealth = MaxHealth;
        }
    }

    // Health increase and decrease functions
    public void GetHealth ()
    {
        CurrentHealth++;
    }

    public void LoseHealth()
    {
        CurrentHealth--;
    }
}
