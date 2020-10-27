﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu]

public class FloatData : ScriptableObject
{
    public float value;

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
        if (value >= 0 || value <= 1)
        {
            img.fillAmount = value;
        }

        if (value <= 0)
        {
            value = 0;
            img.fillAmount = .75f;
        }

        if (value >= 1)
        {
            value = 1;
        }
    }
}