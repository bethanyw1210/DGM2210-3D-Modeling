using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomSpawnLocation : MonoBehaviour
{
    public GameObject obj;

    public Transform parent;
    private Vector3Data spawnLocation;

    public void OnTriggerEnter(Collider other)
    {
        Instantiate(obj, parent);
    }
}
 