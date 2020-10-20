using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]

public class OnTriggerEnter : MonoBehaviour
{
    public Color newColor;
    public Color defaultColor;
    private MeshRenderer meshR;
    private WaitForSeconds wfs;
    public int holdTime = 1;

    void Start()
    {
        meshR = GetComponent<MeshRenderer>();
        meshR.material.color = defaultColor;
        wfs = new WaitForSeconds(1f);
    }

    private void OnTriggerEnter(Collider other)
    {
        meshR.material.color = newColor;
    }

    private IEnumerator OnTriggerExit(Collider other)
    {
        yield return wfs;
        meshR.material.color = defaultColor;
    }
}
