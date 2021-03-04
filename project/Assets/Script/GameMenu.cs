using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenu : MonoBehaviour
{
    //プレイヤーを変数に格納
    public GameObject Player;

    //回転スピード
    public float speed;

    void Start()
    {
        
    }

    void Update()
    {
        //プレイヤー位置情報
        Vector3 playerPos = Player.transform.position;

        //カメラを回転させる
        transform.RotateAround(playerPos, Vector3.up, speed);
    }

    public void GameStart()
    {
        SceneManager.LoadScene("StageSelect");
    }

    public void Message()
    {
        SceneManager.LoadScene("Message");
    }

    public void Back()
    {
        SceneManager.LoadScene("GameMenu");
    }
}
