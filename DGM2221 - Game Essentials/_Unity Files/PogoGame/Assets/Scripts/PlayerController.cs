using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PlayerController : MonoBehaviour
{
    public IntData flightAmount;
    public float flyCount;

    private float normalSpeed = 10f, sprintSpeed = 20f, flyHeight = 10f, gravity = -9.81f;
    private float vInput, hInput, yVar, moveSpeed;
    private CharacterController controller;
    private Vector3 movement;

    private void Start()
    {
        moveSpeed = normalSpeed;
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            moveSpeed = sprintSpeed;
        }

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = normalSpeed;
        }

        hInput = Input.GetAxis("Horizontal") * -moveSpeed;
        vInput = Input.GetAxis("Vertical") * moveSpeed;
        movement.Set(vInput,yVar,hInput);
        
        Vector3 newPosition = new Vector3(-hInput, 0.0f, vInput);
        transform.rotation = Quaternion.LookRotation(newPosition);

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
        
        controller.Move((movement) * Time.deltaTime);
    }
}
