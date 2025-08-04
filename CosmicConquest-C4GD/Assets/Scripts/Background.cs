using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    float repeatWidth;
    void Start()
    {
        BoxCollider2D collider = GetComponent<BoxCollider2D>();
        repeatWidth = collider.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        if (Camera.main.transform.position.x > transform.position.x + repeatWidth)
        {
            transform.position = new Vector3(transform.position.x + repeatWidth, transform.position.y, transform.position.z);
        }
        if (Camera.main.transform.position.x < transform.position.x - repeatWidth)
        {
            transform.position = new Vector3(transform.position.x - repeatWidth, transform.position.y, transform.position.z);
        }
    }
}
