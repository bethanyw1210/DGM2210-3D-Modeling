using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PlayerController : MonoBehaviour
{
    public IntData flightAmount;
    public FloatData flyCount;

    private float normalSpeed = 10f, sprintSpeed = 20f, flyHeight = 10f, gravity = -15f, glideSpeed = -5f;
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
        if (Input.GetKeyDown(KeyCode.LeftShift) && controller.isGrounded)
        {
            moveSpeed = sprintSpeed;
            print("sprinting");
        }

        if (Input.GetKeyUp(KeyCode.LeftShift) && controller.isGrounded)
        {
            moveSpeed = normalSpeed;
            print("walking");
        }
        
        if (Input.GetKey(KeyCode.LeftShift) && !controller.isGrounded)
        {
            yVar = glideSpeed;
            print("gliding");
        }

        if (Input.GetKeyUp(KeyCode.LeftShift) && !controller.isGrounded)
        {
            yVar = gravity;
            print("not gliding");
        }

        hInput = Input.GetAxis("Horizontal") * -moveSpeed;
        vInput = Input.GetAxis("Vertical") * moveSpeed;
        movement.Set(vInput,yVar,hInput);
        
        Vector3 newPosition = new Vector3(-hInput, 0.0f, vInput);
        transform.rotation = Quaternion.LookRotation(newPosition);

        yVar += gravity*Time.deltaTime;

        if (controller.isGrounded && movement.y < 0)
        {
            flyCount.value = 0;
        }

        if (Input.GetButton("Jump") && flyCount.value < flightAmount.value)
        {
            yVar = flyHeight;
            flyCount.value++;
        }
        
        controller.Move((movement) * Time.deltaTime);
    }
}
