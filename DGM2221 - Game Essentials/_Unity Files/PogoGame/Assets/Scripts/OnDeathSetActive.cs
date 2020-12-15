using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeathSetActive : MonoBehaviour
{
    public FloatData enemyHealth;
    public GameObject objInstantiate, objInstantiate2;

    public void Start()
    {
        objInstantiate.SetActive(false);
        objInstantiate2.SetActive(false);
    }

    public void Update()
    {
        if (enemyHealth.value <= .05)
        {
            objInstantiate.SetActive(true);
            objInstantiate2.SetActive(true);
        }
    }
}
