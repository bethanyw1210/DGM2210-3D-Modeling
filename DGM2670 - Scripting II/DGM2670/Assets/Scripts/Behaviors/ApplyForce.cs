using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class ApplyForce : MonoBehaviour
{
    private Rigidbody rBody;
    public Vector3 forces;
    public bool canRunOnstart;

    private void Start()
    {
        rBody = GetComponent<Rigidbody>();

        if (canRunOnstart)
        {
            OnApplyForce();
        }
    }

    public void OnApplyForce()
    {
        rBody.AddRelativeForce(forces);
    }
}
