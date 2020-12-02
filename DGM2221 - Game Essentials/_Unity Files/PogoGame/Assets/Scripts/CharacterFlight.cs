using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterFlight : MonoBehaviour
{
    public CharacterController controller;
    public float flyHeight = 2f, gravity = -9.81f;
    public Vector3 movement;
    public WaitForSeconds holdTime = new WaitForSeconds(2f);
    public WaitForSeconds flyTime = new WaitForSeconds(5f);
    public bool canFly;
    
    private float yVar;

    public void Start()
    {
        canFly = true;
    }

    public void Update()
    {
        yVar += gravity*Time.deltaTime;
        
        movement.Set(0, yVar, 0);
        
        if (Input.GetButtonDown("Jump"))
        {
            yVar = flyHeight;
        }
    }
    
    /*public IEnumerator Fly()
    {
        if (controller.isGrounded)
        {
            canFly = false;
            yield return wfs;
            canFly = true;
        }
    }*/
}
