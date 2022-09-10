using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayMenu : MonoBehaviour
{
    public bool paused = false;

    void Update()
    {
        if (!paused && Input.GetKeyDown(KeyCode.Escape))
        {
            MenuManager.GoToMenu(MenuName.Pause);
            paused = true;
        }
    }

    public void HandlePauseButtonOnClick()
    {
        if (!paused)
        {
            MenuManager.GoToMenu(MenuName.Pause);
        }
    }
}
