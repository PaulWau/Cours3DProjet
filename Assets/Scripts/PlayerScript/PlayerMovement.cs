using System.Collections;
using System.Collections.Generic;
using UnityEditor.Profiling.Memory.Experimental;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    public float speed = 10f;
    public float jumpHeight = 3f;
    public float gravity = -9.81f;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private float groundDistance = 0.3f;
    public LayerMask groundMask;

    private Vector3 velocity;
    private bool isGrounded;
    
    void Update()
    {
    
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        SetSpeed();
        Vector3 move = transform.right * x + transform.forward * y;
        controller.Move(move * speed * Time.deltaTime);

        //Debug.Log(isGrounded);
        if (isGrounded && Input.GetButton("Jump"))
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
        velocity.y += gravity * Time.deltaTime * 2f;
        controller.Move(velocity * Time.deltaTime);
    }

    private void SetSpeed()
    {
        if (Input.GetButton("Sprint"))
        {
            speed = 20f;
        }
        else
        {
            speed = 10f;
        }
    }
}
