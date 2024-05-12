using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;
    private Rigidbody rb;
    public Transform cam;

    private float ySpeed;

    private float speed = 5.0f;
    public float rotationSpeed;
    public float jumpSpeed;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    private bool isGrounded;

    public float dashSpeed = 10f;
    public float dashDuration = 1f;
    private bool isDashing;

    private Vector3 velocity;
    private float desiredRotation;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isDashing)
        {
            return;
        }

        MovePlayer();

        // SPRINT
        if (Input.GetKey("w") && Input.GetKey(KeyCode.LeftShift))
        {
            speed = 5f;
        }
        else
        {
            speed = 2;
        }

        /*        // DASH
                if (Input.GetKey("w") && Input.GetKeyDown(KeyCode.LeftControl))
                {
                    StartCoroutine(Dash(move));
                }*/

        // JUMP
        ySpeed += Physics.gravity.y * Time.deltaTime;

        // GROUNDED
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);


        if (isGrounded == true && Input.GetButtonDown("Jump"))
        {
            velocity.y = jumpSpeed;
        }

        velocity.y += Physics.gravity.y * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    void FixedUpdate()
    {
        if (isDashing)
        {
            return;
        }
    }

    private void MovePlayer()
    {
        // Get input for movement
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        // Calculate movement direction relative to the camera
        Vector3 moveDirection = (cam.forward * z + cam.right * x).normalized;
        moveDirection.y = 0f; // Ensure the player doesn't move up or down

        // Rotate the player towards the movement direction
        if (moveDirection != Vector3.zero)
        {
            desiredRotation = Mathf.Atan2(moveDirection.x, moveDirection.z) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0f, desiredRotation, 0f), rotationSpeed * Time.deltaTime);
        }

        // Calculate movement velocity
        Vector3 moveVelocity = moveDirection * speed;

        // Apply movement velocity
        controller.Move(moveVelocity * Time.deltaTime);
    }

    private IEnumerator Dash(Vector3 move)
    {
        if (!isGrounded)
        {
            yield break;
        }

        isDashing = true;

/*        Vector3 dashVelocity = new Vector3(move.x * dashSpeed, 0, move.z * dashSpeed);*/
        rb.velocity = new Vector3(0, 0, 20);

        Debug.Log("dash");

        yield return new WaitForSeconds(dashDuration);

        isDashing = false;
    }
}
