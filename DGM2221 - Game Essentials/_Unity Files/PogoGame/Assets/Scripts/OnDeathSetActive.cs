using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnDeathSetActive : MonoBehaviour
{
    public FloatData enemyHealth;
    public GameObject objInstantiate, objInstantiate2, objInstantiate3;

    public void Start()
    {
        objInstantiate.SetActive(false);
        objInstantiate2.SetActive(false);
        objInstantiate3.SetActive(false);
    }

    public void Update()
    {
        if (enemyHealth.value <= 0)
        {
            objInstantiate.SetActive(true);
            objInstantiate2.SetActive(true);
            objInstantiate3.SetActive(true);
        }
    }
}
