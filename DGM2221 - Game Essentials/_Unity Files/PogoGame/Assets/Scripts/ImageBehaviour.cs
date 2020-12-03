using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ImageBehaviour : MonoBehaviour
{
    public UnityEvent imageEvent;

    private void Update()
    {
        imageEvent.Invoke();
    }
}
