using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearStartBG : MonoBehaviour
{
    public float rotationSpeed = 40f;
    public float direction = 1f;


    // Update is called once per frame
    void Update()
    {
            StartRotate();

    }

    void StartRotate() // 齿轮旋转函数
    {
        transform.Rotate(Vector3.forward * rotationSpeed * direction * Time.deltaTime, Space.Self);
    }
}