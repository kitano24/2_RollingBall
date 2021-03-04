using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverAction : MonoBehaviour
{
    [SerializeField]
    //　ポーズした時に表示するUIのプレハブ
    private GameObject GameOverUIPrefab;
    //　ポーズUIのインスタンス
    private GameObject GameOverUIInstance;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player") //Objectタグの付いたゲームオブジェクトと衝突したか判別
        {
            Destroy(collision.gameObject);
            GameOverUI();
        }

        if(collision.gameObject.tag == "Bloc")
        {
             Destroy(collision.gameObject);
        }

    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        //if (SceneManager.GetActiveScene().name == "Stage1")
        //{
        //    SceneManager.LoadScene("Stage1");
        //}

        //if (SceneManager.GetActiveScene().name == "Stage2")
        //{
        //    SceneManager.LoadScene("Stage2");
        //}

        //if (SceneManager.GetActiveScene().name == "Stage3")
        //{
        //    SceneManager.LoadScene("Stage3");
        //}

        //if (SceneManager.GetActiveScene().name == "Stage4")
        //{
        //    SceneManager.LoadScene("Stage4");
        //}

        //if (SceneManager.GetActiveScene().name == "Stage5")
        //{
        //    SceneManager.LoadScene("Stage5");
        //}

        //if (SceneManager.GetActiveScene().name == "Stage6")
        //{
        //    SceneManager.LoadScene("Stage6");
        //}

        //if (SceneManager.GetActiveScene().name == "Stage7")
        //{
        //    SceneManager.LoadScene("Stage7");
        //}

        //if (SceneManager.GetActiveScene().name == "Stage8")
        //{
        //    SceneManager.LoadScene("Stage8");
        //}

        //if (SceneManager.GetActiveScene().name == "Stage9")
        //{
        //    SceneManager.LoadScene("Stage9");
        //}

        Resume();
    }

    // メニューに戻る
    public void Quit()
    {
        // 後でゲームメニューに変更
        SceneManager.LoadScene("GameMenu");
        Resume();
    }

    // もう一度プレイ
    void Resume()
    {
        Destroy(gameObject);
        Time.timeScale = 1f;
    }

    // ゲームオーバー画面
    void GameOverUI()
    {
        GameOverUIInstance = GameObject.Instantiate(GameOverUIPrefab) as GameObject;
        Time.timeScale = 0f;
    }

}
