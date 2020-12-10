using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstanceBehaviour : MonoBehaviour
{
    public GameObject prefab;
    public Vector3Data rotationDirection;
    public GameObject newObj;
    public bool canShoot;
    public WaitForSeconds wfs = new WaitForSeconds(.85f);

    public void FireWeapon()
    {
        if (canShoot)
        {
            Instance();
        }
    }

    public void Instance()
    {
        var location = transform.position;
        newObj = Instantiate(prefab, location, Quaternion.Euler(rotationDirection.value));
        StartCoroutine(HoldTime());
    }

    public IEnumerator HoldTime()
    {
        canShoot = false;
        yield return wfs;
        canShoot = true;
    }
}
