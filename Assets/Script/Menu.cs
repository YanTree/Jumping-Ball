using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartGame()
    {
        FindObjectOfType<AudioManager>().Play("button");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Quit()
    {
        FindObjectOfType<AudioManager>().Play("button");
        Debug.Log("QUIE");
        Application.Quit();
    }
}
