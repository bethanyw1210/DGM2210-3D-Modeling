using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthPickupRespawn : MonoBehaviour
{
    public GameObject feather;
    public WaitForSeconds wfs = new WaitForSeconds(12f);
    public FloatData playerHealth;
    public float addHealth = .15f;
    public Image healthBar;
    public bool canHeal;

    public void Start()
    {
        canHeal = true;
    }

    public void Update()
    {
        healthBar.fillAmount = playerHealth.value;
    }

    public IEnumerator OnTriggerEnter(Collider other)
    {
        if (canHeal)
        {
            if (playerHealth.value < 1f)
            {
                playerHealth.value = playerHealth.value + addHealth;
                feather.SetActive(false);
                canHeal = false;
                yield return wfs;
                canHeal = true;
                feather.SetActive(true);
            }
        }
    }
}
