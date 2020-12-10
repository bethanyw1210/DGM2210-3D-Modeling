using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponDamage : MonoBehaviour
{
    public FloatData enemyHealth, weaponDamage;
    public string compareTag;

    private void Update()
    {
        if (enemyHealth.value <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(compareTag))
        {
            var newHealth = enemyHealth.value - weaponDamage.value;
            enemyHealth.value = newHealth;
        }
    }
}
