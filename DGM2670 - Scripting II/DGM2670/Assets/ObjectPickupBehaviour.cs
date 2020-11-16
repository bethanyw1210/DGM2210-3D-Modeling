using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class ObjectPickupBehaviour : MonoBehaviour
{
    private Rigidbody rBody;
    private bool canPickUp;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        canPickUp = Input.GetKeyDown(KeyCode.E);
    }

    private void OnTriggerStay(Collider other)
    {
        if (canPickUp)
        {
            transform.parent = other.transform;
            rBody.Sleep();
            //rBody.isKinematic = true;
            //rBody.useGravity = false;
        }
        else
        {
            transform.parent = null;
            rBody.WakeUp();
            //rBody.isKinematic = false;
            //rBody.useGravity = true;
        }
    }
}
