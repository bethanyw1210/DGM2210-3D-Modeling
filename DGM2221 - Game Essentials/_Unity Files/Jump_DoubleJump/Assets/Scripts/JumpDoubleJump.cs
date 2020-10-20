using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(CharacterController))]
public class JumpDoubleJump : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 positionDirection;
    public float gravity = 1f, jumpForce = 30f, jumpCountMax = 5f;
    private float jumpCount;

    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            positionDirection.y = 0;
            jumpCount = 0;
        }

        if (Input.GetButtonDown("Jump") && jumpCount < jumpCountMax)
        {
            positionDirection.y = jumpForce;
            jumpCount++;
        }
        positionDirection.y -= gravity;
        controller.Move(positionDirection*Time.deltaTime);
    }
}
