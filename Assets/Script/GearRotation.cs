using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GearRotation : MonoBehaviour
{
    public float rotationSpeed = 40f;
    public float direction = 1f;


    // Update is called once per frame
    void Update()
    {
        if (SwitchGearTrigger.isGreen) // 当触发开关时，齿轮开始旋转
        {
            StartRotate();
        }
        //StartRotate();
    }

    void StartRotate() // 齿轮旋转函数
    {
        transform.Rotate(Vector3.forward * rotationSpeed * direction * Time.deltaTime, Space.Self);
    }
}
