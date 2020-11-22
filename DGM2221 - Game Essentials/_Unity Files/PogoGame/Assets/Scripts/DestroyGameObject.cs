using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class DestroyGameObject : MonoBehaviour
{
    public GameObject destroyObj;
    
    public void OnTriggerEnter(Collider other)
    {
        Destroy(destroyObj);
    }
}
