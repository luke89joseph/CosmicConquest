using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class deathScreenUI : MonoBehaviour
{
    public Button back;
    // Start is called before the first frame update
    void Start()
    {
        back.onClick.AddListener(goBack);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void goBack()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
