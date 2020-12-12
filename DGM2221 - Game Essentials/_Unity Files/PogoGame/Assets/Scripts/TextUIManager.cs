using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class TextUIManager : MonoBehaviour
{
    public UnityEvent startEvent;
    private Text textLabel;

    public void UpdateText(IntData data)
    {
        textLabel.text = data.value.ToString();
    }

    private void Awake()
    {
        textLabel = GetComponent<Text>();
        startEvent.Invoke();
    }
}
