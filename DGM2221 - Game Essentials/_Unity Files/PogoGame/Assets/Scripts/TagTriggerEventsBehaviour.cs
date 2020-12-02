using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TagTriggerEventsBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent;
    public string compareTag;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(compareTag))
        {
            triggerEnterEvent.Invoke();
        }
    }
}
