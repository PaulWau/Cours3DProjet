using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private CharacterController controller;
    public float speed = 13f;
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
        OpenMenu();
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
            speed = 18f;
        }
        else
        {
            speed = 13f;
        }
    }

    private void OpenMenu()
    {
        if (!GameManager.settingsMenu.activeSelf)
        {
            if (Input.GetButtonUp("Cancel"))
            {
                Cursor.lockState = CursorLockMode.Confined;
                GameManager.playerInterface.SetActive(false);
                GameManager.settingsMenu.SetActive(true);
            }
        }
        else
        {
            if (Input.GetButtonUp("Cancel"))
            {
                Cursor.lockState = CursorLockMode.Locked;
                GameManager.playerInterface.SetActive(true);
                GameManager.settingsMenu.SetActive(false);
            }
        }
    }
}
