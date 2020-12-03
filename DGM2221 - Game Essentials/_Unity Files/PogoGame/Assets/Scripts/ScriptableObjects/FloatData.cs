using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu]

public class FloatData : ScriptableObject
{
    public float value;
    public string objTag;

    public void SetValue(float number)
    {
        value = number;
    }
    
    public void UpdateValue(float number)
    {
        value += number;
    }
    
    public void SetImageFillAmount(Image img)
    {
        if (value >= 0 || value <= 1 && GameObject.FindGameObjectWithTag(objTag))
        {
            img.fillAmount = value;
        }
    }
    public void SetImageFillAmountNoTag(Image img)
    {
        img.fillAmount = value;
    }
}
