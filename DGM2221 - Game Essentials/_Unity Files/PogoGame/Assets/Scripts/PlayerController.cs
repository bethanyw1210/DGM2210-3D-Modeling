using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]

public class PlayerController : MonoBehaviour
{
    public IntData flightAmount;
    public FloatData flyCount;
    public float maxGlide;

    private float normalSpeed = 10f, sprintSpeed = 20f, flyHeight = 10f, gravity = -9.81f, glideSpeed = -1f;
    private float vInput, hInput, yVar, moveSpeed;
    private CharacterController controller;
    private Vector3 movement;
    private WaitForSeconds wfs = new WaitForSeconds(2f);
    private bool canGlide;

    private void Start()
    {
        moveSpeed = normalSpeed;
        controller = GetComponent<CharacterController>();
        maxGlide = 0;
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
        
        if (Input.GetKey(KeyCode.LeftShift) && !controller.isGrounded && maxGlide < 100f)
        {
            yVar = glideSpeed;
            maxGlide++;
            moveSpeed = normalSpeed;
            print("gliding");

            if (maxGlide >= 100f)
            {
                yVar = gravity;
                print("falling");
            }
        }

        if (Input.GetKeyUp(KeyCode.LeftShift) && !controller.isGrounded)
        {
            yVar = gravity;
            print("not gliding");
        }

        if (controller.isGrounded)
        {
            maxGlide = 0f;
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
