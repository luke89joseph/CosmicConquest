using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody2D rb;
    public float speed = 5f;
    public bool isLeft = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        if (isLeft)
        {
            transform.Translate(Vector2.left * Time.deltaTime * speed);
        }
        else
        {
            transform.Translate(Vector2.right * Time.deltaTime * speed);
        }
        

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LeftTrigger"))
        {
            isLeft = false;
        }
        if (collision.gameObject.CompareTag("RightTrigger"))
        {
            isLeft = true;
        }
    }
    
}
