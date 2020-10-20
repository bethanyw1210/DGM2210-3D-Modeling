using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PlayerController : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 movement;

    public float rotateSpeed = 300f, gravity = 1f, maxFlyCount = 5f, flyHeight = 15f;
    private float yVar, flyCount;

    public FloatData normalSpeed, sprintSpeed;
    private FloatData moveSpeed;
    private bool canMove = true;

    private void Start()
    {
        moveSpeed = normalSpeed;
        controller = GetComponent<CharacterController>();
        StartCoroutine(Move());
    }
    
    private readonly WaitForFixedUpdate wffu = new WaitForFixedUpdate();
    private IEnumerator Move()
    {
        canMove = true;
        while (canMove)
        {
            yield return wffu;
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                moveSpeed = sprintSpeed;
            }

            if (Input.GetKeyUp(KeyCode.LeftShift))
            {
                moveSpeed = normalSpeed;
            }
        
            var vInput = Input.GetAxis("Vertical")*moveSpeed.value;
            
            movement.Set(vInput,yVar,0);
        
            var hInput = Input.GetAxis("Horizontal")*Time.deltaTime*rotateSpeed;
            transform.Rotate(0,hInput,0);

            yVar += gravity*Time.deltaTime;
            
            if (controller.isGrounded && movement.y < 0)
            {
                yVar = -1f;
                flyCount = 0;
            }

            if (Input.GetButtonDown("Jump") && flyCount < maxFlyCount)
            {
                yVar = flyHeight;
                flyCount++;
            }

            movement = transform.TransformDirection(movement);
            controller.Move((movement) * Time.deltaTime);
        }
    }
}
