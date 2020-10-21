using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterWithStates : MonoBehaviour
{
    private CharacterController controller;
    public CharacterStateMachineData characterStates;

    private Vector3 movement;
    public float moveSpeed = 3f, gravity = -9.81f;


    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        var newInput = Input.GetAxis("Vertical")*moveSpeed;
        
        switch (characterStates.value)
        {
            case CharacterStateMachineData.characterStates.StandardWalk:
                movement.Set(newInput,gravity,0);
                print("Normal walk");
                break;
            case CharacterStateMachineData.characterStates.NoGravityWalk:
                movement.Set(newInput,0,0);
                print("Normal walk");
                break;
            case CharacterStateMachineData.characterStates.WallCrawl:
                movement.Set(0,newInput,0);
                print("Wall crawl");
                break;
            case CharacterStateMachineData.characterStates.Knockback:
                print("Knockback");
                break;
        }

        var newMovement = moveSpeed * Time.deltaTime;
        controller.Move(newMovement);
    }
}
