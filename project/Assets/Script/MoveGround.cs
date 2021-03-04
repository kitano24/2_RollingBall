using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGround : MonoBehaviour
{
    bool isChange;

    void Start()
    {
        isChange = false;
    }

    void Update()
    {
 
        // transformを取得
        Transform myTransform = this.transform;

        // 座標を取得
        Vector3 pos = myTransform.position;
    
        if (pos.z > 3.8)
        {
            isChange = true;
        }


        if (pos.z < -3.8)
        {
            isChange = false;
        }
        
        if (isChange == false)
        {
            pos.z += 0.05f;   
        }

        if (isChange == true)
        {
            pos.z -= 0.05f;
        }

        // 座標を設定
        myTransform.position = pos; 
    }
}
