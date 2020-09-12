using UnityEngine;
using UnityEngine.UI;

public class PlayerDiedUI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameManager GM;
    [SerializeField] GameObject player;
    [SerializeField] Image cicleImg;       // 做动画的img
    [SerializeField] Text textProgress;    // 倒计时数字

    [SerializeField] [Range(0, 1)] float progress = 0f;
    [SerializeField] float speed = 0.1f;   // 控制倒计时速度

    void IncreaseProgress()                // 增加 progress 值
    {
        cicleImg.fillAmount = progress;    // 填充 fillAmount
        progress += speed * Time.deltaTime;
        textProgress.text = Mathf.Floor(4 - progress * 3).ToString();  // mathf.floor 用于将数字转化为整数
    }
    // Update is called once per frame
    void Update()
    {
        if (progress <= 1)                 // 当没有填充完毕时，也就是 continue 界面还没消失
        {
            player.GetComponent<PlayerMove>().enabled = false; // 静止玩家移动
            IncreaseProgress();                                // 继续填充 fillAmount
        }       
        else                               // 当填充完毕时
        {
            gameObject.SetActive(false);                       // continue 界面已经没用了，让他消失
            player.GetComponent<PlayerMove>().enabled = true;  // 玩家可以移动了
            progress = 0f;                                     // 将 progress 重置，为下次玩家的死亡作好前提工作
            GM.PlayerTryAgain();                               // 玩家再一次尝试，这里有设置复活点
        }
        
    }
}
