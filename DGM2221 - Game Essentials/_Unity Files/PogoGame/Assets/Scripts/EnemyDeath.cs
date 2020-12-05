using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public FloatData enemyHealth;
    public float startHealth;

    public void Start()
    {
        enemyHealth.value = startHealth;
    }

    public void Update()
    {
        if (enemyHealth.value <= 0)
        {
            Destroy(gameObject);
        }
    }
}
