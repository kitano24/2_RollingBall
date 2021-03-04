using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxAction : MonoBehaviour
{
    public Rigidbody rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    void Update()
    {
        float h = Input.GetAxis("Horizontal"); // 水平方向の操作（-1～0～1）
        float v = Input.GetAxis("Vertical"); // 垂直方向の操作（-1～0～1）
        this.transform.position += new Vector3(0, 0, v / 10);
    }
}
