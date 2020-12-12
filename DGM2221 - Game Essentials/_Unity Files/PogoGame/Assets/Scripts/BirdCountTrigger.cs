using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BirdCountTrigger : MonoBehaviour
{
    public string compareTag;
    public IntData birdCount;

    public void Start()
    {
        birdCount.value = 0;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(compareTag))
        {
            birdCount.value++;
        }
    }
}
