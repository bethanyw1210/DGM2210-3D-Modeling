using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class MonoEventsBehaviour : MonoBehaviour
{
    public UnityEvent startEvent, onEnableEvent;

    private void Start()
    {
        startEvent.Invoke();
    }

    private void OnEnable()
    {
        onEnableEvent.Invoke();
    }
}
