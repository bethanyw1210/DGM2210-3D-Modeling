using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceGameObjectPrefab : MonoBehaviour
{
    public GameObject prefab;

    public void Instance()
    {
        var newObj = Instantiate(prefab);
    }
}
