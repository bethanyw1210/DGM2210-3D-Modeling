using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class ShootWeapon : MonoBehaviour
{
    private WaitForSeconds spawnTime = new WaitForSeconds(.5f);
    public GameObject weapon, spawnPoint;

    public void Start()
    {
        StartCoroutine(SpawnWeapon());
    }

    public IEnumerator SpawnWeapon()
    {
        while (true)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                Instantiate(weapon, spawnPoint.transform.position, Quaternion.identity);
                print("shoot");
            }
            yield return spawnTime;
        }
    }
}
