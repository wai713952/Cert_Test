using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreshow : MonoBehaviour
{
    public Text textscore;
    public score scorecheck;
    private int scorelast;
    public Text win;
    void Start()
    {
        textscore = GetComponent<Text>();
    }
    void Update()
    {
        scorelast = scorecheck.GetComponent<score>().scorecount;
        textscore.text = "score: " + scorelast;
        if(scorelast == 8)
        {
            win.text = "You Win!!!";
            textscore.gameObject.SetActive(false);
        }
    }
}
