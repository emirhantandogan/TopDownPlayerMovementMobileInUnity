using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;
    public Joystick joystick;
    public float moveX_public;
    public float moveY_public; 
    public Animator animator;


    void Update()
    {
        processInputs();
    }

    private void FixedUpdate()
    {
        Move();
    }

    void processInputs() 
    {
        float moveX = joystick.Horizontal;
        float moveY = joystick.Vertical;

        animator.SetFloat("Horizontal", moveX);
        animator.SetFloat("Vertical", moveY);
        animator.SetFloat("Speed", rb.velocity.magnitude);

        moveDirection = new Vector2(moveX, moveY).normalized;
        
    }

    void Move() 
    {
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }
}
