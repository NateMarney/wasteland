﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
Moves the player character.
*/
public class PlayerMovement : MonoBehaviour
{

    Animator animator; //animator reference variable


    public float moveSpeedX = 2f;
    public float moveSpeedZ = 3f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    
    public CharacterController controller;

    Vector3 velocity;
    bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        //get animator component
        animator = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);


        if(isGrounded && velocity.y < 0)
        {
            
            velocity.y = -2f;
        }

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = transform.right * moveX * moveSpeedX * Time.deltaTime + transform.forward * moveZ * moveSpeedZ * Time.deltaTime;
        
        //velocity.x += move.x;
        //velocity.z += move.z;

        controller.Move(move);

        bool isWalking = animator.GetBool("isWalking");
        bool isRunning = animator.GetBool("isRunning");
        bool forwardPressed = Input.GetKey("w");
        bool runPressed = Input.GetKey("left shift");
        
        // if player presses w key
        if (!isWalking && forwardPressed)
        {
            // set the isWalking boolean to be true (located in Unity animator parameters)
            animator.SetBool("isWalking", true);
        }

        if (isWalking && !forwardPressed)
        {
            animator.SetBool("isWalking", false);
        }

        if (!isRunning && (isWalking && runPressed))
        {
            animator.SetBool("isRunning", true);
        }

        if (!forwardPressed || !runPressed)
        {
            animator.SetBool("isRunning", false);
        }

        if (Input.GetKey("left shift") && Input.GetKey("w"))
        {
            animator.SetBool("isRunning", true);
            controller.Move(move * moveSpeedZ * 100 * Time.deltaTime);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
            
         //JUMP ANIMATION   
            animator.SetBool("isRunJumping", true);      
        }
        else
        {
            animator.SetBool("isRunJumping", false);       
        }

        // if(Input.GetButtonDown("Crouch") && isGrounded)
        //{
        //    move *= 0.5;
        //    change cylinder size to be smaller
        //}

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }
}
