using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class GameAction : ScriptableObject
{
    public UnityAction action;
    public UnityAction<Transform> transformAction;

    public void RaiseAction()
    {
        action?.Invoke();
    }

    public void RaiseAction(Transform obj)
    {
        Debug.Log(obj);
        transformAction(obj);
    }
}
