using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class LavaDeath : MonoBehaviour
{
    public FloatData playerHealth;
    public float lavaDmg = 2f;
    public string colliderTag;
    public GameObject playerObj;
    public Vector3Data playerRespawnPosition;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(colliderTag))
        {
            playerHealth.value = playerHealth.value - lavaDmg;
            //playerObj.transform.position = playerRespawnPosition.value;
        }
    }
}
