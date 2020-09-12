using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerController PC;

    void Update()
    {
        if (PC.m_IsTrap()) // 检测是否碰撞了 Trap
        {
            PC.enabled = false; // 是的话，禁止玩家移动
            FindObjectOfType<GameManager>().PlayerDied(); // 执行 PlayDied() 函数，调出死亡界面
        }   
    }
}
