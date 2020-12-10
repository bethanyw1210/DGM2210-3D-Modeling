using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChangeWeapon : MonoBehaviour
{
    public string compareTag;
    public UnityEvent changeWeaponEvent;
    public FloatData originalWeaponDmg;
    public float newWeaponDmg;
    public GameObject weapon;
    public Material startColor;
    
    public void Start()
    {
        weapon.GetComponent<MeshRenderer>().material = startColor;
        originalWeaponDmg.value = .05f;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(compareTag))
        {
            originalWeaponDmg.value = newWeaponDmg;
            changeWeaponEvent.Invoke();
        }
    }
}
