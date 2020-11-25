using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public FloatData enemyHealth;

    public void Start()
    {
        enemyHealth.value = .1f;
    }

    public void Update()
    {
        if (enemyHealth.value <= 0)
        {
            Destroy(gameObject);
        }
    }
}
