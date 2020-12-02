using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;

public class PlayerDeath : MonoBehaviour
{
    public FloatData playerHealth;
    public WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    private MeshRenderer meshRenderer;
    public UnityEvent playerEvent;
    public Vector3Data playerRespawnPosition;
    public GameObject playerObj;

    public void Start()
    {
        playerHealth.value = 1f;
    }

    public void Update()
    {
        if (playerHealth.value <= 0)
        {
            StartCoroutine(RespawnPlayer());
        }
    }

    private IEnumerator RespawnPlayer()
    {
        yield return wffu;
        playerObj.transform.position = playerRespawnPosition.value;  /*not being called >:( */
        playerHealth.value = .75f;
        playerEvent.Invoke();
    }
}
