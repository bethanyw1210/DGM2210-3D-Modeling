using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class UIImageBahaviour : MonoBehaviour
{
    public UnityEvent startEvent;
    private Image imgObj;
    public FloatData valueAmount;

    public void UpdateImage(FloatData data)
    {
        imgObj.fillAmount = valueAmount.value;
    }

    private void Awake()
    {
        imgObj = GetComponent<Image>();
        startEvent.Invoke();
    }

}
