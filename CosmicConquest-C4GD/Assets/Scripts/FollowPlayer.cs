using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject Player;
    public GameObject deathScreen;
    // Start is called before the first frame update
    void Start()
    {
        Player = FindObjectOfType<PlayerController>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (!deathScreen.activeSelf)
        {
            transform.position = new Vector3(Player.transform.position.x, transform.position.y, transform.position.z);
        }
    }
}
