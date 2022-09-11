using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    public void HandleNextButtonOnClick()
    {
        Time.timeScale = 1;
        // Not implemented
        throw new System.Exception("Next button not implemented.");
    }

    public void HandleHomeButtonOnClick()
    {
        Time.timeScale = 1;
        MenuManager.GoToMenu(MenuName.Main);
    }
}
