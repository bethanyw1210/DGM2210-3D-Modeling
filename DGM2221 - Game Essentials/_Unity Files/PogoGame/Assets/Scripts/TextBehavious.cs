using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBehavious : MonoBehaviour
{
    private Text textObj;
    public IntData dataObj;
    
    void Start()
    {
        textObj = GetComponent<Text>();
    }
    
    void Update()
    {
        textObj.text = dataObj.value.ToString();
    }
}
