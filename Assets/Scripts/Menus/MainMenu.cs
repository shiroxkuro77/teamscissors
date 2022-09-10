using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void HandlePlayButtonOnClick()
    {
        SceneManager.LoadScene("Level1");
    }

    public void HandleQuitButtonOnClick()
    {
        Application.Quit();
    }
}
