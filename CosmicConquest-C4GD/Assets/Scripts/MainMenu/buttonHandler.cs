using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public Button startButton;

    public void StartButtonPressed()
    {
        SceneManager.LoadScene("Level 1");
    }

    // Start is called before the first frame update
    void Start()
    {
        startButton.onClick.AddListener(StartButtonPressed);
    }
}
