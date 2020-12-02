using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIImageBahaviour : MonoBehaviour
{
    private Image img;

    void Awake()
    {
        img = GetComponent<Image>();
    }

    public void UpdateImage(FloatData data)
    {
        img.fillAmount = data.value / 100;
    }
}
