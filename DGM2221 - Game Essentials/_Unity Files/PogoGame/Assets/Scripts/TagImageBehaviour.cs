using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TagImageBehaviour : MonoBehaviour
{
    public UnityEvent imageEvent;
    public string objTag;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == objTag)
        {
            imageEvent.Invoke();
        }
    }
}
