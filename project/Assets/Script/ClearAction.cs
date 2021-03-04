using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClearAction : MonoBehaviour
{
    public GameObject particleObject;

    int count;            // プレイヤーのカウント
 
    [SerializeField]
    //　ポーズした時に表示するUIのプレハブ
    private GameObject GameClearUIPrefab;
    //　ポーズUIのインスタンス
    private GameObject GameClearUIInstance;

    void Start()
    {
        count = 0;
    }

    // ステージをクリアしたら次のステージ
    public void NextStage()
    {
        if (SceneManager.GetActiveScene().name == "Stage1")
        {
            SceneManager.LoadScene("Stage2");
        }

        if (SceneManager.GetActiveScene().name == "Stage2")
        {
            SceneManager.LoadScene("Stage3");
        }

        if (SceneManager.GetActiveScene().name == "Stage2")
        {
            SceneManager.LoadScene("Stage3");
        }

        if (SceneManager.GetActiveScene().name == "Stage3")
        {
            SceneManager.LoadScene("Stage4");
        }

        if (SceneManager.GetActiveScene().name == "Stage4")
        {
            SceneManager.LoadScene("Stage5");
        }

        if (SceneManager.GetActiveScene().name == "Stage5")
        {
            SceneManager.LoadScene("Stage6");
        }

        if (SceneManager.GetActiveScene().name == "Stage6")
        {
            SceneManager.LoadScene("Stage7");
        }

        if (SceneManager.GetActiveScene().name == "Stage7")
        {
            SceneManager.LoadScene("Stage8");
        }

        if (SceneManager.GetActiveScene().name == "Stage8")
        {
            SceneManager.LoadScene("Stage9");
        }

        if (SceneManager.GetActiveScene().name == "Stage9")
        {
            SceneManager.LoadScene("Stage10");
        }

        if (SceneManager.GetActiveScene().name == "Stage10")
        {
            SceneManager.LoadScene("Stage11");
        }

        if (SceneManager.GetActiveScene().name == "Stage11")
        {
            SceneManager.LoadScene("Stage12");
        }
        
        if (SceneManager.GetActiveScene().name == "Stage12")
        {
            SceneManager.LoadScene("Stage13");
        }

        if (SceneManager.GetActiveScene().name == "Stage13")
        {
            SceneManager.LoadScene("Stage14");
        }

        if (SceneManager.GetActiveScene().name == "Stage14")
        {
            SceneManager.LoadScene("Stage15");
        }

        if (SceneManager.GetActiveScene().name == "Stage15")
        {
            SceneManager.LoadScene("Stage16");
        }

        if (SceneManager.GetActiveScene().name == "Stage16")
        {
            SceneManager.LoadScene("Stage17");
        }

        if (SceneManager.GetActiveScene().name == "Stage17")
        {
            SceneManager.LoadScene("Stage18");
        }

    }

    // ステージセレクトに戻る
    public void StageSelect()
    {
        SceneManager.LoadScene("StageSelect");
    }

    // ゲームクリア画面
    void GameClearUI()
    {
        GameClearUIInstance = GameObject.Instantiate(GameClearUIPrefab) as GameObject;
    }

    // 当たるとクリア、プレイヤーを消して爆発モーション
    void OnTriggerExit(Collider other)
    {
        // ステージ6＆7　は玉が2つなので
        if (other.gameObject.tag == "Player" && SceneManager.GetActiveScene().name == "Stage6"
            || SceneManager.GetActiveScene().name == "Stage7")
        {
            count += 1;
            Instantiate(particleObject, this.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            if(count == 2) GameClearUI();
        }

        // ステージ8は玉が3つなので
        if (other.gameObject.tag == "Player" && SceneManager.GetActiveScene().name == "Stage8"
            || SceneManager.GetActiveScene().name == "Stage9")
        {
            count += 1;
            Instantiate(particleObject, this.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            if (count == 3) GameClearUI();
        }

        if (other.gameObject.tag == "Player" && SceneManager.GetActiveScene().name == "Stage1"
            || SceneManager.GetActiveScene().name == "Stage2"
            || SceneManager.GetActiveScene().name == "Stage3"
            || SceneManager.GetActiveScene().name == "Stage4"
            || SceneManager.GetActiveScene().name == "Stage5"
            || SceneManager.GetActiveScene().name == "Stage10"
            || SceneManager.GetActiveScene().name == "Stage11"
            || SceneManager.GetActiveScene().name == "Stage12"
            || SceneManager.GetActiveScene().name == "Stage13"
            || SceneManager.GetActiveScene().name == "Stage14" 
            || SceneManager.GetActiveScene().name == "Stage15" 
            || SceneManager.GetActiveScene().name == "Stage16"
            || SceneManager.GetActiveScene().name == "Stage17")
        {
            GameClearUI();
            // パーティクル用ゲームオブジェクト生成
            Instantiate(particleObject, this.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
        }
    }
}
