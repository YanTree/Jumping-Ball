using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGearTrigger : MonoBehaviour
{
    private Material _Material;
    public static bool isGreen = false;

    private void Awake()
    {
        _Material = this.transform.GetComponentInParent<Renderer>().materials[0]; // 获取 Material 组件
    }
    private void OnTriggerEnter()       // 当玩家触发开关
    {
        Debug.Log("Enter Trigger!");
        
        if (isGreen == false)          // 判断开关是否打开，red 为初始值，代表关闭
        {
            _Material.color = Color.green; // 改变开关的颜色为绿色，代表打开
            FindObjectOfType<AudioManager>().Play("switch");
            isGreen = true;
        }
    }
}
