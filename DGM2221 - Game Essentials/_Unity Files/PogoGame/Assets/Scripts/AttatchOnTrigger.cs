using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttatchOnTrigger : MonoBehaviour
{
    public string colliderTag;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(colliderTag))
        {
            transform.parent = other.transform;
            print("parented");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        transform.parent = null;
    }
}
