using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool gamePaused = false;
    public GameObject pauseMenuUI, mouseManger;
    public string mainMenu;

    public void Start()
    {
        pauseMenuUI.SetActive(false);
        mouseManger.SetActive(true);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (gamePaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        mouseManger.SetActive(true);
        Time.timeScale = 1f;
        gamePaused = false;
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        mouseManger.SetActive(false);
        Time.timeScale = 0f;
        gamePaused = true;
    }
    
    public void QuitGame()
    {
        Debug.Log("quitting game...");
        Application.Quit();
    }
}
