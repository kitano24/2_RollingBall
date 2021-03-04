using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //uGUIを扱うのに必要

public class PlayerAction : MonoBehaviour
{
    Rigidbody myRB; // 自身のリジッドボディを代入する入れ物
    public bool activate = true; // この機能をON/OFFする為の真偽値
    public Text txtMessage;
    bool isPlaying; //プレイ中か
    float Elapsed; //経過時間

    void Start()
    {
        Elapsed = 0.0f;

        myRB = GetComponent<Rigidbody>(); // リジッドボディに命令したいので取得する
        
        isPlaying = false;
    }
   
    void Update()
    {
        if (Time.timeScale != 0)
        {
            if (isPlaying)
            {
                GetComponent<Rigidbody>().WakeUp();
                if (activate)
                {
                    if (Application.platform == RuntimePlatform.IPhonePlayer ||
                        Application.platform == RuntimePlatform.Android)
                    {
                        float h = Input.acceleration.x;
                        float v = Input.acceleration.y;
                        myRB.AddForce(new Vector3(h, 0, v) * 30.0f); // 内部から力を与える。
                    }
                    else
                    {
                        float h = Input.GetAxis("Horizontal"); // 水平方向の操作（-1～0～1）
                        float v = Input.GetAxis("Vertical"); // 垂直方向の操作（-1～0～1）
                        myRB.AddForce(new Vector3(h, 0, v) * 10.0f); // 内部から力を与える。
                    }
                }
            }
            else
            {
                Elapsed += Time.deltaTime;
                Elapsed %= 2.0f;
                txtMessage.text = (Elapsed < 1.6f) ? "Touch to START" : "";

                if (Input.GetMouseButtonDown(0))
                { //画面タッチ検出
                    txtMessage.text = "";
                    isPlaying = true;
                }
            }
        }
    }
}
