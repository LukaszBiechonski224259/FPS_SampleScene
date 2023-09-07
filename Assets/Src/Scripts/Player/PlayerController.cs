using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    [Header("References")]
    Rigidbody rb;
    public Transform orientation;

    [Header("Config")]
    private float horizontalInput, verticalInput;
    private Vector3 movementDirection;
    private bool grounded;
    public float movementSpeed;
    public float dragForce;
    public float playerHeight;
    public LayerMask WhatIsGround;
    
    


    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {
        PlayerInput();
        GroundCheck();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
    }

    private void PlayerInput()
    {
        horizontalInput = Input.GetAxisRaw("Horizontal");
        verticalInput = Input.GetAxisRaw("Vertical");
    }

    private void Move()
    {
        movementDirection = orientation.forward * verticalInput + orientation.right * horizontalInput;
        rb.AddForce(movementDirection.normalized * (movementSpeed * 10f), ForceMode.Force);
        
    }

    private void GroundCheck()
    {
        grounded = Physics.Raycast(transform.position, Vector3.down, playerHeight * 0.5f + 0.2f, WhatIsGround);
        if (grounded)
            rb.drag = dragForce;
        else
            rb.drag = 0;

    }


}
