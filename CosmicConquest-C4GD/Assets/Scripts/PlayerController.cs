using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horInput =10f;
    public float moveSpeed = 8f;
    public float jumpSpeed;
    public Transform groundCheckPoint;
    public LayerMask groundLayer;
    float groundCheckRadius = 0.2f;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horInput = Input.GetAxisRaw("Horizontal");
        float nextVelocityX = horInput * moveSpeed;
        float nextVelocityY = rb.velocity.y;
        bool isGrounded = checkGround();
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            nextVelocityY = jumpSpeed;
            
        }
        rb.velocity = new Vector2(nextVelocityX, nextVelocityY);
    }
    bool checkGround()
    {
        return Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
    }
}
