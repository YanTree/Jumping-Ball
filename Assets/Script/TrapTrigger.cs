using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    [SerializeField] GameManager GM;

    private void OnTriggerEnter() // 当玩家触发 Trigger
    {
        GM.PlayerDied();          // 代表着玩家死亡
    }
}
