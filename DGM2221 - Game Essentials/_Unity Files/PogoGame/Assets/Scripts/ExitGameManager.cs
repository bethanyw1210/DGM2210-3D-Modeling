using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitGameManager : MonoBehaviour
{
    public void Exit()
    {
        print("quiting game...");
        Application.Quit();
    }
}
