using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    GameplayMenu gameplayMenu;

    void Start()
    {
        Time.timeScale = 0;
        gameplayMenu = GameObject.FindObjectOfType<Camera>().GetComponent<GameplayMenu>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Time.timeScale = 1;
            gameplayMenu.paused = false;
            Destroy(gameObject);
        }
    }

    public void HandleResumeButtonOnClick()
    {
        Time.timeScale = 1;
        gameplayMenu.paused = false;
        Destroy(gameObject);
    }

    public void HandleHomeButtonOnClick()
    {
        Time.timeScale = 1;
        gameplayMenu.paused = false;
        MenuManager.GoToMenu(MenuName.Main);
    }
}
