using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ImageBehaviour : MonoBehaviour
{
    private Image imgObj;
    public IntData dataObj;
    
    void Start()
    {
        imgObj = GetComponent<Image>();
    }
    
    void Update()
    {
        imgObj.fillAmount = dataObj.value;
    }
}
