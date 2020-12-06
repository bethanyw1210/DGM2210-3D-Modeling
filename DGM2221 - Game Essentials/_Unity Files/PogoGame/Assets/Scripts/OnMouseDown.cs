using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnMouseDown : MonoBehaviour
{
    public UnityEvent mouseDownEvent;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mouseDownEvent.Invoke();
        }
    }
}
