using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceBehaviour : MonoBehaviour
{
    public GameObject prefab;
    public Vector3Data rotationDirection;
    public GameObject newObj;

    public void Instance()
    {
        var location = transform.position;
        newObj = Instantiate(prefab, location, Quaternion.Euler(rotationDirection.value));
    }
}
