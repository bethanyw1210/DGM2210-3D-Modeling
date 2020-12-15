using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class BabyBirdManager : MonoBehaviour
{
    public GameObject babyBird;

    public FloatData playerHealth;
    public IntData birdCount;
    public int birdNumber;

    public void Update()
    {
        if (playerHealth.value <= 0 && (birdCount.value == birdNumber))
        {
            babyBird.SetActive(false);
        }
    }
}


