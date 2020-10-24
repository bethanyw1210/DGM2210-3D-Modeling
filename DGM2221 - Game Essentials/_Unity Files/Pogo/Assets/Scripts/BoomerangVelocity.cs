using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomerangVelocity : MonoBehaviour
{
    public bool canShoot = true;
    public Rigidbody rBody;
    public WaitForFixedUpdate wffu = new WaitForFixedUpdate();

    public IEnumerator Start()
    {
        var originalVelocity = rBody.velocity;
        while (canShoot)
        {
            rBody.velocity = Vector3.Lerp(rBody.velocity, -originalVelocity, .1f);
            yield return wffu;
        }
    }

}
