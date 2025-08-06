using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHP = 10f;
    public float currHP = 0f;
    public bool player;
    private Rigidbody2D rb;
    public GameObject deathScreen;
    // Start is called before the first frame update
    void Start()
    {
        deathScreen = GameObject.FindWithTag("Death Screen");
        deathScreen.SetActive(false);
        currHP = maxHP;
        rb = GetComponent<Rigidbody2D>();
    }

    public void TakeDamage(float amt)
    {
        currHP -= amt;

        if (currHP <= 0)
        {
            if (player)
            {
                deathScreen.SetActive(true);
            }
            Destroy(gameObject);
   
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(1);
        }
    }
}
