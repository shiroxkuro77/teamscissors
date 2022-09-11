using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    public void HandlePlayButtonOnClick()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level1");
    }

    public void HandleHomeButtonOnClick()
    {
        Time.timeScale = 1;
        MenuManager.GoToMenu(MenuName.Main);
    }
}
