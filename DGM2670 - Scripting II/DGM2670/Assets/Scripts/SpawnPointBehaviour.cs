using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPointBehaviour : MonoBehaviour
{
    public Vector3Data vData;

    private void OnTriggerEnter(Collider other)
    {
        vData.SetValueFromVector3(transform.position);
    }
}
