using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDeath : MonoBehaviour
{
    public FloatData playerHealth;
    public GameObject player;

    public void Start()
    {
        playerHealth.value = 1;
    }

    private void Update()
    {
        if (playerHealth.value <= 0)
        {
            player.transform.position = new Vector3(-65, 2, 0);
            playerHealth.value = .75f;
        }
    }
}
