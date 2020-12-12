using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]

public class LoadLevel : ScriptableObject
{
    public string level;

    public void LoadScene()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(level);
    }
}
