using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LastStageClear : MonoBehaviour
{
    public GameObject particleObject;
 
    [SerializeField]
    //　ポーズした時に表示するUIのプレハブ
    private GameObject LastClearUIPrefab;
    //　ポーズUIのインスタンス
    private GameObject LastClearUIInstance;

    // これ以上ステージがないのでStageSelectボタンのみ描画
    void LastStageClearUI()
    {
        LastClearUIInstance = GameObject.Instantiate(LastClearUIPrefab) as GameObject;
    }

    public void StageSelect()
    {
        SceneManager.LoadScene("StageSelect");
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && SceneManager.GetActiveScene().name == "Stage18")
        {
            Instantiate(particleObject, this.transform.position, Quaternion.identity);
            Destroy(other.gameObject);
            LastStageClearUI();
        }
    }
}
