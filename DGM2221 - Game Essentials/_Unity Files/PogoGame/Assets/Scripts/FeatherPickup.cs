using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeatherPickup : MonoBehaviour
{
    public FloatData playerHealth;
    public float addHealth = .15f;
    public GameObject featherObj;
    public string colliderTag;
    public bool canHeal;

    public void OnTriggerEnter(Collider other)
    {
        if (playerHealth.value < 1)
        {
            canHeal = true;
            
            if (other.CompareTag(colliderTag) && (canHeal = true) && (playerHealth.value <= .85))
            {
                playerHealth.value = playerHealth.value + addHealth;
                Destroy(featherObj);
            }
            
            if (other.CompareTag(colliderTag) && (canHeal = true) && (playerHealth.value > .85))
            {
                playerHealth.value = 1;
                Destroy(featherObj);
            }
        }

        if (playerHealth.value > 1)
        {
            canHeal = false;
        }
        
    }
}
