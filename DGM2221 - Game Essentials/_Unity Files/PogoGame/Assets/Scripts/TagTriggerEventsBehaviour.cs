using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TagTriggerEventsBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent, triggerExitEvent;
    public string compareTag;
    public float enterDelayTime = 0.01f, exitDelayTime = 0.01f;


    private IEnumerator OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(compareTag))
        {
            yield return new WaitForSeconds(enterDelayTime);
            triggerEnterEvent.Invoke();
        }
    }

    private IEnumerator OnTriggerExit(Collider other)
    {
        if (other.CompareTag(compareTag))
        {
            yield return new WaitForSeconds(exitDelayTime);
            triggerExitEvent.Invoke();
        }
    }
}
