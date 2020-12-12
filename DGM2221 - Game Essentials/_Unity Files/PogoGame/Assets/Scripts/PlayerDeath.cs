using System;
using System.Collections;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class PlayerDeath : MonoBehaviour
{
    public FloatData playerHealth;
    public WaitForSeconds wfs = new WaitForSeconds(2f);
    private MeshRenderer meshRenderer;
    public UnityEvent playerEvent;
    public Vector3Data playerRespawnPosition;
    public GameObject playerObj;
    public Image img;
    public IntData birdCount;


    public void Start()
    {
        playerHealth.value = 1f;
    }

    public void Update()
    {
        if (playerHealth.value <= 0 && (birdCount.value > 0))
        {
            RespawnPlayer();
            img.fillAmount = playerHealth.value;
        }
    }

    private void RespawnPlayer()
    {
        playerObj.transform.position = playerRespawnPosition.value;
        playerHealth.value = .75f;
        birdCount.value--;
        playerEvent.Invoke();
    }
}
