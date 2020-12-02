using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ImageBehaviour : MonoBehaviour
{
    public UnityEvent damagePlayer;
    public string objTag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == objTag)
        {
            damagePlayer.Invoke();
        }
    }
}
