using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu]
public class StringListData : ScriptableObject
{
    public List<string> stringList;
    
    private string returnValue;

    private int indexer;

    private void OnEnable()
    {
        indexer = 0;
    }
    
    public void GetNextString()
    {
        returnValue = stringList[indexer];
        indexer = (indexer + 1) % stringList.Count;
    }

    public void SetTextUIToValue(Text obj)
    {
        obj.text = returnValue;
    }
}
