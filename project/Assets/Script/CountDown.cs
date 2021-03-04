using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    public float time;
    //時間を表示するText型の変数
    public Text timeText;

    void Start()
    {
        
    }

    void Update()
    {
        time -= Time.deltaTime;
        //時間を表示する
        timeText.text = time.ToString("0");

        if(time <= 0)
        {
            SceneManager.LoadScene("Stage3");
        }
    }
}
