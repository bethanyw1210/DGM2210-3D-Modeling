using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotation : MonoBehaviour
{
    public float rotateSpeed = 5f;
    public GameObject obj;
    
    public void Update()
    {
        obj.transform.rotation = Quaternion.Lerp(obj.transform.rotation, Quaternion.identity, rotateSpeed*Time.deltaTime);
        print("running");
    }
}
