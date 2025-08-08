using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField]private float timeCounter;
    [SerializeField] private int minutes;
    [SerializeField] private int seconds;
    [SerializeField] private TextMeshProUGUI timerText;
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        timeCounter += Time.deltaTime;
        minutes = Mathf.FloorToInt(timeCounter / 60);
        seconds = Mathf.FloorToInt(timeCounter - minutes * 60);
        if(timerText != null) timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
