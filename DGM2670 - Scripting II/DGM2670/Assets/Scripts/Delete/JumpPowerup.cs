using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPowerup : MonoBehaviour
{
    public IntData playerJumpCount, powerUpCount, normalJumpCount;
    public float waitTime = 5f;

    private void Start()
    {
        playerJumpCount.value = normalJumpCount.value;
    }

    private IEnumerator OnTriggerEnter(Collider other)
    {
        playerJumpCount.value = powerUpCount.value;
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;
        yield return new WaitForSeconds(waitTime);
        playerJumpCount.value = normalJumpCount.value;
        gameObject.SetActive(false);
    }
}
