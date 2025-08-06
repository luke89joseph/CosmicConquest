using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialUI : MonoBehaviour
{
    public GameObject group;
    private bool tut;
    // Start is called before the first frame update
    void Start()
    {
        group.SetActive(false);
        tut = false;
    }

    // Update is called once per frame
    void Update()
    {
        group.SetActive(tut);
        if (Input.GetKeyDown(KeyCode.T))
        {
            if (tut)
            {
                tut = false;
            }
            else
            {
                tut = true;
            }
        }
    }
}
