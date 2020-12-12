using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

[RequireComponent(typeof(CharacterController))]

public class PlayerController : MonoBehaviour
{
    public FloatData flightAmount;
    public FloatData flyCount, gravity;
    public float maxGlide;
    public IntData walkSpeed;

    public Image flyBar;
    public Image glideBar;

    private float flyHeight = 10f, glideSpeed = -1f;
    private float vInput, hInput, yVar, moveSpeed;
    private CharacterController controller;
    private Vector3 movement;
    private WaitForSeconds wfs = new WaitForSeconds(2f);
    private bool canGlide;

    private void Start()
    {
        moveSpeed = walkSpeed.value;
        controller = GetComponent<CharacterController>();
        maxGlide = 0;
        flightAmount.value = 40;
        gravity.value = -9.81f;
        flyBar.fillAmount = 0f;
    }

    private void Update()
    {
        flyBar.fillAmount = flyCount.value;
        glideBar.fillAmount = maxGlide;

        if (flyCount.value == flightAmount.value)
        {
            flyBar.fillAmount = 0;
        }

        if (maxGlide == 100f)
        {
            glideBar.fillAmount = 0;
        }

        if (Input.GetKey(KeyCode.LeftShift) && !controller.isGrounded && maxGlide < 100f)
        {
            yVar = glideSpeed;
            maxGlide++;
            moveSpeed = walkSpeed.value;
            print("gliding");

            if (maxGlide >= 100f)
            {
                yVar = gravity.value;
                print("falling");
            }
        }

        if (Input.GetKeyUp(KeyCode.LeftShift) && !controller.isGrounded)
        {
            yVar = gravity.value;
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

        yVar += gravity.value*Time.deltaTime;

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
