using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MouseEventsBehaviour : MonoBehaviour
{
    public UnityEvent mouseDownEvent;
    public MeshRenderer weapon;
    public WaitForSeconds wfs = new WaitForSeconds(1.1f);

    public void Start()
    {
        weapon.enabled = true;
    }

    private IEnumerator OnMouseDown()
    {
        weapon.enabled = false;
        mouseDownEvent.Invoke();
        yield return wfs;
        weapon.enabled = true;
    }
}
