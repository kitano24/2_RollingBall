using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAction : MonoBehaviour
{
    GameObject Target;
    Vector3 Offset = new Vector3(0, 1.4f, 0); //ターゲットの少し上
    Vector3 CamPos;
    Vector3 newPos;
    float nowRotate;
  //   ①変数の定義（データを入れるための箱を作る）
  //  public GameObject target;
  //  private Vector3 offset;


    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
        CamPos = transform.position;
 //        ②代入（作成した箱の中にデータを入れる）
 //       offset = transform.position - target.transform.position;
    }

    void LateUpdate()
    {
        // ③活用（データの入った箱を活用する）
    //    transform.position = target.transform.position + offset;
        if (!Target)
            return; //ターゲット不在なら動かさない。
        //ターゲットのＹ角度と同じになるような角度を徐々に求める。
        nowRotate = Mathf.LerpAngle(transform.eulerAngles.y,
        Target.transform.eulerAngles.y, 2.0f * Time.deltaTime);
        //ターゲット位置から新しい座標newPosを計算し、徐々に自分に与える。
        newPos = Target.transform.position -
        Quaternion.Euler(0, nowRotate, 0) * Vector3.forward * Mathf.Abs(CamPos.z);
        newPos.y = Mathf.Lerp(transform.position.y,
        Target.transform.position.y + CamPos.y, 3.0f * Time.deltaTime);
        transform.position = newPos;
        //カメラの注視点はターゲットの少し上を狙う。
        transform.LookAt(Target.transform.position + Offset);
    }

    void Update()
    {
        
    }
}
