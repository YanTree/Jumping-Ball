using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompleteGame : MonoBehaviour
{
    [SerializeField] GameManager GM;

    private void OnTriggerEnter(Collider player)
    {
        GM.CompleteGame(); // 加载胜利时的UI
        player.GetComponent<PlayerMove>().enabled = false; // 静止玩家移动
    }
}
