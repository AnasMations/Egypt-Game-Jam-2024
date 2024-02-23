using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RunnerMovement : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 20.0f;
    private float gravityValue = -9.81f;
    [SerializeField] Rigidbody rb;
    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        Moving();        
    }

    private void Moving()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        //Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), -0.1f, 0.2f);

        controller.Move(move * Time.fixedDeltaTime * playerSpeed);




        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        //Changes the height position of the player..
        //if (Input.GetButtonDown("Jump") && groundedPlayer)
        //{
        //    playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
        //}

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
        transform.rotation = Quaternion.Euler(transform.rotation.x, 0, 0);

    }
}
