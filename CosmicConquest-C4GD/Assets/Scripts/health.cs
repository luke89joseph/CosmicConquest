using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float maxHP = 10f;
    public float currHP = 0f;
    public bool player;
    // Start is called before the first frame update
    void Start()
    {
        currHP = maxHP;
    }

    public void TakeDamage(float amt)
    {
        currHP -= amt;

        if (currHP <= 0)
        {
            Destroy(gameObject);
        }
    }
}
