using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float moveSpeedX = 2f;
    public float moveSpeedZ = 3f;
    public float gravity = -9.81f;
    public float jumpHeight = 3f;
    public float patrolDistance = 10;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    public CharacterController controller;

    bool isGrounded;
    private Vector3 startPosition;

    public float moveDelay = 3f;


    Animator animator; //animator reference variable

    Vector3 velocity;
    Vector3 move = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        //get animator component
        animator = GetComponent<Animator>();
        startPosition = transform.position;
        StartCoroutine(MoveAfterTime(moveDelay));
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        move = patrol(move);
        controller.Move(move);
        animator.SetFloat("forwardVelocity", Vector3.Dot(move, transform.forward));
    }
    
    /*
     After a few seconds, set move direction forward.
     */
    IEnumerator MoveAfterTime(float time)
    {
        yield return new WaitForSeconds(time);
        move = transform.forward * moveSpeedZ * Time.deltaTime;
    }

    Vector3 patrol(Vector3 move)
    {
        Vector2 horizontalStartPosition = new Vector2(startPosition.x, startPosition.z);
        Vector2 horizontalPosition = new Vector2(transform.position.x, transform.position.z);


        //var distanceToStart = Vector3.Distance(new Vector3(startPosition.x, 0, startPosition.z), new Vector3(transform.position.x, 0, startPosition.z));
        float distanceToStart = Vector2.Distance(horizontalStartPosition, horizontalPosition);
        //Mathf.Abs(startPosition.z - transform.position.z);

        Vector3 newMove = Vector3.zero; // default

        //if (move.z > 1e-7)
        if (Vector3.Dot(move.normalized, transform.forward) == 1)
        {
            if (distanceToStart < patrolDistance)
            {
                newMove = transform.forward * moveSpeedZ * Time.deltaTime;
            }
            else
            {
                newMove = -transform.forward * moveSpeedZ * Time.deltaTime;
            }
        } //else if (move.z < -1e-7)
        else if (Vector3.Dot(move.normalized, transform.forward) == -1)
        {
            Debug.Log("Moving Backwards");
            if (distanceToStart > 2)
            {
                newMove = -transform.forward * moveSpeedZ * Time.deltaTime;
            }
            else
            {
                newMove = transform.forward * moveSpeedZ * Time.deltaTime;
            }
        }

        return newMove;
    }

}
