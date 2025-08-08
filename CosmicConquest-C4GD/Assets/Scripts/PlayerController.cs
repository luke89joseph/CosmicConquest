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
    public GameObject projectileRightPrefab;
    public GameObject projectileLeftPrefab;
    private float activeSpeed;
    public float dashSpeed;
    public float dashLength = 0.5f;
    public float dashCoolDown = 1f;
    public float dashCounter;
    private float dashCoolCounter;
    private Animator anim;
    public bool isRight;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        activeSpeed = moveSpeed;
       isRight = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        horInput = Input.GetAxisRaw("Horizontal");
        if (horInput < 0)
        {
            transform.localScale = new Vector3(-0.6822429f, 0.6665732f, 1);
            isRight = false;
        }
        else if (horInput > 0)
        {
            transform.localScale = new Vector3(0.6822429f, 0.6665732f, 1);
            isRight = true;
        }
        float nextVelocityX = horInput * activeSpeed;
        float nextVelocityY = rb.velocity.y;
        bool isGrounded = checkGround();
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            nextVelocityY = jumpSpeed;
            
        }
        rb.velocity = new Vector2(nextVelocityX, nextVelocityY);
        if (Input.GetKeyDown(KeyCode.LeftShift) || Input.GetKeyDown(KeyCode.RightShift))
        {
            if (isRight)
            {
                
                Instantiate(projectileRightPrefab, transform.position, projectileRightPrefab.transform.rotation);
            }else if (!isRight)
            {
                Instantiate(projectileLeftPrefab, transform.position, projectileLeftPrefab.transform.rotation);
            }
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (dashCoolCounter <= 0 && dashCounter <= 0)
            {
                activeSpeed = dashSpeed;
                dashCounter = dashLength;
            }
        }
        if (dashCounter > 0)
        {
            dashCounter -= Time.deltaTime;
            if (dashCounter <= 0)
            {
                activeSpeed = moveSpeed;
                dashCoolCounter = dashCoolDown;
            }
        }
        if (dashCoolCounter > 0)
        {
            dashCoolCounter -= Time.deltaTime;
        }
        anim.SetBool("Grounded", checkGround());
        anim.SetFloat("ySpeed", nextVelocityY);
        anim.SetFloat("xSpeed", Mathf.Abs(nextVelocityX));
        if (transform.position.y < -50)
        {
            gameObject.GetComponent<Health>().TakeDamage(1000);
            Destroy(gameObject);
        }
    }
    bool checkGround()
    {
        return Physics2D.OverlapCircle(groundCheckPoint.position, groundCheckRadius, groundLayer);
    }
    
}
