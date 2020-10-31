using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TriggerEventsBehaviour : MonoBehaviour
{
    public UnityEvent triggerEnterEvent, triggerExitEvent,triggerStayEvent;
    public float enterDelayTime = 0.01f, exitDelayTime = 0.01f, stayDelayTime = 0.01f;
    

    private IEnumerator OnTriggerEnter(Collider other)
    {
        yield return new WaitForSeconds(enterDelayTime);
        triggerEnterEvent.Invoke();
    }

    private IEnumerator OnTriggerExit(Collider other)
    {
        yield return new WaitForSeconds(exitDelayTime);
        triggerExitEvent.Invoke();
    }

    private IEnumerator OnTriggerStay(Collider other)
    {
        yield return new WaitForSeconds(stayDelayTime);
        triggerStayEvent.Invoke();
    }
}
