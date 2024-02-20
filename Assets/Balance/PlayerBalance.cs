using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBalance : MonoBehaviour
{
    public float movementSpeed = 5f;
    public float jumpForce = 10f;

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Check if the player is grounded
        CheckGrounded();

        // Handle player movement
        float horizontalInput = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(horizontalInput, 0f, 0f) * movementSpeed;
        // rb.velocity = new Vector3(movement.x, rb.velocity.y, 0f);
        rb.AddForce(movement, ForceMode.Force);

        // Handle player jump
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    void CheckGrounded()
    {
        // Raycast to check if the player is grounded
        float raycastDistance = 1f; // Adjust this based on your player's size
        isGrounded = Physics.Raycast(transform.position, Vector3.down, raycastDistance);
    }
}
