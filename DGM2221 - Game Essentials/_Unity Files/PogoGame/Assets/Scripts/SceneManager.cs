using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public string loadLevel;

    public FloatData playerHealth;
    public IntData birdCount;

    public void Update()
    {
        if (playerHealth.value <= 0 && (birdCount.value <= 0))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(loadLevel);
        }
    }
}
