using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    [SerializeField]
    //　ポーズした時に表示するUIのプレハブ
    private GameObject pauseUIPrefab;
    //　ポーズUIのインスタンス
    private GameObject pauseUIInstance;

    public static bool GameIsPaused = false;

    public void OnClick()
    {
        //Time.timeScale=0の場合停止する
        if (Time.timeScale == 0)
        {
            Resume();
        }
        else
        {
            Pause();
        }
    }

    public void OnClickRESTART()
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
    public void OnClickQUIT()
    {
        SceneManager.LoadScene("GameMenu");
        Resume();
    }

    // ゲームに戻る
    void Resume()
    {
        Destroy(gameObject);
        Time.timeScale = 1f;
    }
    
    // ポーズ画面
    void Pause()
    {
        pauseUIInstance = GameObject.Instantiate(pauseUIPrefab) as GameObject;
        Time.timeScale = 0f;
    }
}
