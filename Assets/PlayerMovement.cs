using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeedX = 15f;
    public float moveSpeedZ = 15f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    
    public CharacterController controller;

    Vector3 velocity;
    bool isGrounded;

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float moveX = Input.GetAxis("Horizontal") * moveSpeedX * Time.deltaTime;
        float moveZ = Input.GetAxis("Vertical") * moveSpeedZ * Time.deltaTime;

        Vector3 move = transform.right * moveX + transform.forward * moveZ;

        controller.Move(move);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
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
