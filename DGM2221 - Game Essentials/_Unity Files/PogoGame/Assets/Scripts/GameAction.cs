using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameAction : ScriptableObject
{
    public UnityAction action;
    public UnityAction<Transform> transAction;

    public void RaiseAction()
    {
        action?.Invoke();
    }

    public void RaiseActionTrans(Transform obj)
    {
        Debug.Log(obj);
        transAction(obj);
    }
}
