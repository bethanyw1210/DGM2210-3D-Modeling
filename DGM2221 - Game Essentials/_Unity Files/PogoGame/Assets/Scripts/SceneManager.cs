using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public string gameOver, playerWon, notEnough;

    public FloatData playerHealth, bossHealth;
    public IntData birdCount;

    public void Update()
    {
        if (playerHealth.value <= 0 && (birdCount.value <= 0) && (bossHealth.value > 0))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(gameOver);
        }

        if (bossHealth.value <= 0 && (birdCount.value >= 3) && (playerHealth.value > 0))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(playerWon);
        }
        
        if (bossHealth.value <= 0 && (birdCount.value < 3) && (playerHealth.value > 0))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(notEnough);
        }
    }
}
