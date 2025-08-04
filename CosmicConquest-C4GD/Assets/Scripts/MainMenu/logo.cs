using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example : MonoBehaviour
{
    RectTransform m_RectTransform;
    float m_XAxis, m_YAxis;
    public float speed = 1f;
    public float magnitude = 20f; // divide by 3 to shorten the curve dip
    public float offset = 210f; // The base Y position
    private float _time = 0f;

    void Start()
    {
        //Fetch the RectTransform from the GameObject
        m_RectTransform = GetComponent<RectTransform>();
        //Initiate the x and y positions
        m_XAxis = 0.5f;
        m_YAxis = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        //m_RectTransform.anchoredPosition = new Vector3(-0.00016769f, 22800.14f*(Mathf.Sin(Time.deltaTime)/3)+50, 0);
        _time += Time.deltaTime*speed;
        float y = (Mathf.Sin(_time) * magnitude) + offset;
        m_RectTransform.anchoredPosition = new Vector3(-0.00016769f, y, 0);
    }
}
