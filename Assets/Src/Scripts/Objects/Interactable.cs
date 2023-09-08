using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    [Header("Config")]
    public int durability;
    public string material;
    
    
    

    public void BaseInteract()
    {
        Interact();
    }

    protected virtual void Interact()
    {
        
    }

    public void TakeDamage(int amount )
    {
        durability -= amount;
        if (durability <= 0f)
        {
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }

     protected virtual void OnDestroy()
    {
        
    }
}
