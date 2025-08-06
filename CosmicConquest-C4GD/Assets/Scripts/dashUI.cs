using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dashUI : MonoBehaviour
{
    public GameObject player;
    public Image circle;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float counter = player.GetComponent<PlayerController>().dashCounter;
        if (counter > 0)
        {
            circle.color = new Color(0.9f, 0f, 0f);
        }
        else
        {
            circle.color = new Color(0.4f, 0f, 0f);
        }
    }
}
