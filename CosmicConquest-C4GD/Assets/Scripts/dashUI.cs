using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class dashUI : MonoBehaviour
{
    public GameObject player;
    public Image circle;
    public GameObject deathScreen;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!deathScreen.activeSelf) { 
        float counter = player.GetComponent<PlayerController>().dashCounter;
        if (counter > 0)
        {
            circle.color = new Color(0.9f, 0f, 0f);

            if (SceneManager.GetActiveScene().name == "Level 2")
                {
                    circle.color = new Color(0.902f, 0.675f, 0f);
                    //new Color(0.4f, 0.302f, 0f); 
                }
            }
        else
        {
            circle.color = new Color(0.4f, 0f, 0f);
                if (SceneManager.GetActiveScene().name == "Level 2")
                {
                    circle.color = new Color(0.4f, 0.302f, 0f);
                }
            }
    }
}
}
