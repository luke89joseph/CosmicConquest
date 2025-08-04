using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private float horInput;
    public float moveSpeed;
    public float jumpSpeed;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horInput = Input.GetAxisRaw("Horizontial");
        float nextVelocityX = horInput * moveSpeed;
        float nextVelocityY = rb.velocity.y;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            nextVelocityY = jumpSpeed;
            
        }
        rb.velocity = new Vector2(nextVelocityX, nextVelocityY);
    }
}
