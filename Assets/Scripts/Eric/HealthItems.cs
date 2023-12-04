using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class HealthItems : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void On2DTriggerEnter(Collider other)
    {
        // Checking if the colliding object is a healing item's trigger

        if(other.tag == "Heal_Item")
        {
            var healthComponent = other.GetComponent<Health>();
            if (healthComponent!= null)
            {
                // Adding a float value of 1 health to the maxhealth

                healthComponent.CurrentHealth += 1;
                // Making sure the player doesn't go over the max health when picking up health items
                if (healthComponent.CurrentHealth > healthComponent.MaxHealth)
                {
                    healthComponent.CurrentHealth = healthComponent.MaxHealth;
                }
                return;
            }
            // Disables the heal_item game object upon collision with player
            other.gameObject.SetActive(false);
        }

        if(other.tag == "Enemy")
        {
            // Losing 1 health when colliding with an enemy object's trigger

            var healthComponent = other.GetComponent<Health>();
            healthComponent.CurrentHealth -= 1;
        }
    }
}
