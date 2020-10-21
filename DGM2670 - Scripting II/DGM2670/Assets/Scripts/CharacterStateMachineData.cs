using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class CharacterStateMachineData : ScriptableObject
{
    public enum characterStates
    {
        StandardWalk, 
        WallCrawl,
        Knockback,
        NoGravityWalk
    }

    public characterStates value;

    public UnityEvent onEnableEvent;

    public void OnEnable()
    {
        onEnableEvent.Invoke();
    }

    public void StandardWalk()
    {
        value = characterStates.StandardWalk;
    }
    
    public void WallCrawl()
    {
        value = characterStates.WallCrawl;
    }
    
    public void Knockback()
    {
        value = characterStates.Knockback;
    }
}
