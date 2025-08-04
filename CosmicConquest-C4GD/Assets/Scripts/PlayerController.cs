using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horInput =10f;
    public float moveSpeed = 8f;
    public float jumpSpeed;
    
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
        if (Input.GetKeyDown(KeyCode.Space))
        {
            nextVelocityY = jumpSpeed;
            
        }
        rb.velocity = new Vector2(nextVelocityX, nextVelocityY);
    }
}
