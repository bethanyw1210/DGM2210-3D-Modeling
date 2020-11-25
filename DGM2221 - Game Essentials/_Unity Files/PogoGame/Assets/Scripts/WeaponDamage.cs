using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class WeaponDamage : MonoBehaviour
{
    public UnityEvent damageEvent;

    public void OnTriggerEnter(Collider other)
    {
        if (GameObject.FindGameObjectWithTag("Weapon"))
        {
            damageEvent.Invoke();
        }
    }
}
