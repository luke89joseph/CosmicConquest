using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class hpBar : MonoBehaviour
{
    public GameObject player;
    public GameObject deathScreen;

    public Image bg;
    public Image bar;
    public TextMeshProUGUI label;

    float curr;
    float max;
    float percent;
    // Start is called before the first frame update
    void Start()
    {
        bg.color = new Color(0f, 0.2f, 0f);
        bar.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {
        if (!deathScreen.activeSelf)
        {
            curr = player.GetComponent<Health>().currHP;
            max = player.GetComponent<Health>().maxHP;

            percent = curr / max;

            if (player == null)
            {
                percent = 0f;
            }

            bar.fillAmount = percent;
            label.text = "" + Mathf.RoundToInt(percent * 100) + "%";
            //print(percent);

            if (percent >= 0.7f)
            {
                bg.color = new Color(0f, 0.2f, 0f);
                bar.color = new Color(0f, 0.502f, 0f);
            }
            else if (percent >= 0.4f)
            {
                bg.color = new Color(1.0f, 0.502f, 0.0f);
                bar.color = new Color(1.0f, 0.678f, 0.2f);
            }
            else
            {
                bg.color = new Color(0.6f, 0.149f, 0f);
                bar.color = Color.red;
            }

        }
    }
}
