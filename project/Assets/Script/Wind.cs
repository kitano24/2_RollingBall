using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wind : MonoBehaviour
{
    public float coefficient;   // 空気抵抗係数
    public Vector3 velocity;    // 風速

    void OnTriggerStay(Collider col)
    {
        if (col.attachedRigidbody == null)
        {
            return;
        }

        // 相対速度計算
        var relativeVelocity = velocity - col.attachedRigidbody.velocity;

        // 空気抵抗を与える
        col.attachedRigidbody.AddForce(coefficient * relativeVelocity);
    }
}
