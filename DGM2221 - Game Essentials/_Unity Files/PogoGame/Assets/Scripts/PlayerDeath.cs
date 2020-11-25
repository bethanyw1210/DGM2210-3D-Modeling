using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayerDeath : MonoBehaviour
{
    public FloatData playerHealth;
    public WaitForSeconds wfs = new WaitForSeconds(2f);
    private MeshRenderer meshRenderer;
    public UnityEvent playerEvent;

    public void Start()
    {
        playerHealth.value = 1f;
    }

    public IEnumerator OnTriggerEnter(Collider other)
    {
        if (playerHealth.value <= 0)
        {
            yield return wfs;
            playerHealth.value = .75f;
            playerEvent.Invoke();
        }
    }
}
