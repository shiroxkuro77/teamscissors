using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameplayMenu : MonoBehaviour
{
    public bool paused = false;

    // Timer support
    [SerializeField]
    private TextMeshProUGUI timerText;
    private string timerPrefix = "Time left: ";
    public Timer gameTimer;
    public float gameTime;

    void Start()
    {
        gameTimer = gameObject.AddComponent<Timer>();
        gameTimer.Duration = gameTime;
        gameTimer.Run();
        timerText.text = timerPrefix + Mathf.RoundToInt(
            gameTime - gameTimer.ElapsedSeconds).ToString() + "s";
    }

    void Update()
    {
        if (!paused && Input.GetKeyDown(KeyCode.Escape))
        {
            MenuManager.GoToMenu(MenuName.Pause);
            paused = true;
            gameTimer.Pause();
        }

        if (gameTimer.Finished)
        {
            MenuManager.GoToMenu(MenuName.GameOver);
            Destroy(this);
        }
        timerText.text = timerPrefix + Mathf.RoundToInt(
            gameTime - gameTimer.ElapsedSeconds).ToString() + "s";
    }

    public void HandlePauseButtonOnClick()
    {
        if (!paused)
        {
            MenuManager.GoToMenu(MenuName.Pause);
        }
    }
}
