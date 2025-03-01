using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool isAlive = true;
    public float RunSpeed;
    public float HorizontalSpeed;
    public Rigidbody rb;
    float horizontalInput;

    [SerializeField] float JumpForce = 350;
    [SerializeField] LayerMask GroundMask;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        if (isAlive)
        {
            Vector3 forwardMovement = transform.forward * RunSpeed * Time.fixedDeltaTime;
            Vector3 horizontalMovement = transform.right * horizontalInput * HorizontalSpeed * Time.fixedDeltaTime;
            rb.MovePosition(rb.position + forwardMovement + horizontalMovement);
        }
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        float playerHeight = GetComponent<Collider>().bounds.size.y;
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (playerHeight / 2) + 0.1f, GroundMask);
    }

    public void Jump()
    {
        rb.AddForce(Vector3.up * JumpForce);
    }

}
