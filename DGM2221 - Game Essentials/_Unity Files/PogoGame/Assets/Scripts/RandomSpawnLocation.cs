using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawnLocation : MonoBehaviour
{
    public float minX = -31f, minY = 4f, minZ = 1.5f;
    public float maxX = -33f, maxY = 6f, maxZ = 5.5f;

    public GameObject obj;

    public void SpawnObj()
    {
        float x = Random.Range(minX, maxX);
        float y = Random.Range(minY, maxY);
        float z = Random.Range(minZ, maxZ);

        Instantiate(obj, new Vector3(x, y, z), Quaternion.identity);
    }
}
 