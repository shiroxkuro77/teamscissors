using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class MenuManager
{
    public static void GoToMenu(MenuName name)
    {
        switch (name)
        {
            case MenuName.Main:
                SceneManager.LoadScene("Home");
                break;

            case MenuName.Pause:
                Object.Instantiate(Resources.Load("PauseMenu"));
                break;

            case MenuName.GameOver:
                Object.Instantiate(Resources.Load("GameOverMenu"));
                break;

            case MenuName.Win:
                Object.Instantiate(Resources.Load("WinMenu"));
                break;
        }
    }
}
