using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Vector3 arcPoint;            // 用于更新存档点
    public GameObject player;
    public GameObject playerDiedUI;
    public GameObject completeGameUI;

    // Pause Menu
    public static bool gameIsPause = false; // 判断游戏是否暂停
    public GameObject pauseMenuUI;

    private void Awake()
    {
        arcPoint = player.transform.position; // 设置存档点的初始值为玩家初始位置
        //Debug.Log("start arcPoint: " + arcPoint);
    }

    public void PlayerDied()
    {
        Debug.Log("Player Died!");
        playerDiedUI.SetActive(true);

    }

    public void DelayInableRender()
    {
        player.GetComponent<TrailRenderer>().enabled = true;  // 开启 TrailRenderer
    }
    public void PlayerTryAgain()
    {
        Debug.Log("Player Try Again!");
        player.GetComponent<TrailRenderer>().enabled = false; // 关闭 TrailRenderer ，因为当玩家回到存档点时画面会撕裂
        player.transform.position = arcPoint;                 // 将玩家位置放在存档点
        Invoke("DelayInableRender", 1f);
        Debug.Log(player.transform.position);
    }
    public void CompleteGame()
    {
        Time.timeScale = 0f;
        completeGameUI.SetActive(true);

    }
    // Restart Game
    public void Restart()
    {
        Time.timeScale = 1f;        // 恢复游戏进程，表现出运动的画面
        SwitchGearTrigger.isGreen = false;
        SwitchSlideTrigger.isGreen = false;
        ArcPoint.isGreen = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Quit Game
    public void Quit()
    {
        Debug.Log("Quit!");
        Application.Quit();
    }

    // Pause Menu
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;        // 恢复游戏进程，表现出运动的画面
        gameIsPause = false;
    }
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;        // 冻结游戏进程，表现出画面被卡住
        gameIsPause = true;
    }

    void Update()
    {
        Debug.Log("arcPoint: " + arcPoint);
        if (Input.GetKeyDown(KeyCode.Escape))  // 当按下 Escape 键，跳出暂停UI
        {
            if(gameIsPause)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }   
    }

    public void LoadMenu()                       // 返回游戏开始界面
    {
        Time.timeScale = 1f;
        SwitchGearTrigger.isGreen = false;
        SwitchSlideTrigger.isGreen = false;
        ArcPoint.isGreen = false;
        SceneManager.LoadScene("Scenes/Menu");
    }
}
