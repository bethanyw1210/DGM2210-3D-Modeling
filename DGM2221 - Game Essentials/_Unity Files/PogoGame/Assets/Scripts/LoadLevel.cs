using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]

public class LoadLevel : ScriptableObject
{
    public string levelLoad;

    public void LoadScene()
    {
        SceneManager.LoadScene(levelLoad);
    }
}
