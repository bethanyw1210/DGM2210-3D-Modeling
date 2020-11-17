using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PlayerController : MonoBehaviour
{
    public FloatData normalSpeed, sprintSpeed;
    public IntData flightAmount;
    public float rotateSpeed = 300f, flyHeight = 15f;

    private float gravity = -9.81f;
    private CharacterController controller;
    private Vector3 movement;
    private float vInput, hInput, yVar, flyCount;
    private FloatData moveSpeed;
    private readonly WaitForFixedUpdate wffu = new WaitForFixedUpdate();

    private void Start()
    {
        moveSpeed = normalSpeed;
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        hInput = Input.GetAxis("Horizontal")*Time.deltaTime*rotateSpeed;
        transform.Rotate(0,hInput,0);
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = sprintSpeed;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = normalSpeed;
        }
        
        vInput = Input.GetAxis("Vertical")*moveSpeed.value;
        movement.Set(vInput,yVar,hInput);

        yVar += gravity*Time.deltaTime;

        if (controller.isGrounded && movement.y < 0)
        {
            yVar = -1f;
            flyCount = 0;
        }

        if (Input.GetButtonDown("Jump") && flyCount < flightAmount.value)
        {
            yVar = flyHeight;
            flyCount++;
        }
        movement = transform.TransformDirection(movement);
        controller.Move((movement) * Time.deltaTime);
    }
}
