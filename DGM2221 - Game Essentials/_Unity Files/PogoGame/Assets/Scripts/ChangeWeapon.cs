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
    public GameObject weapon, chest;
    public Material startColor;
    public FloatData playerHealth;
    public float newHealth;
    public GameObject healthBar, healthBarBG;
    
    public void Start()
    {
        weapon.GetComponent<MeshRenderer>().material = startColor;
        originalWeaponDmg.value = .05f;
        healthBar.SetActive(false);
        healthBarBG.SetActive(false);
        playerHealth.value = 1;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(compareTag))
        {
            originalWeaponDmg.value = newWeaponDmg;
            playerHealth.value = newHealth;
            healthBar.SetActive(true);
            healthBarBG.SetActive(true);
            changeWeaponEvent.Invoke();
            Destroy(chest);
        }
    }
}
