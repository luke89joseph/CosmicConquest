using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EndPoint : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            print(1);
            if (SceneManager.GetActiveScene().name.Equals("Level 1"))
            {
                
                
                SceneManager.LoadScene("Level 2");
            }else if(SceneManager.GetActiveScene().name.Equals("Level 2"))
            {
                print(2);
                SceneManager.LoadScene("Level 3");
            }
        }
    }
}
