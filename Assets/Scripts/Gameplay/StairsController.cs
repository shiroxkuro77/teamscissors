using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StairsController : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        MenuManager.GoToMenu(MenuName.Win);
    }
}
