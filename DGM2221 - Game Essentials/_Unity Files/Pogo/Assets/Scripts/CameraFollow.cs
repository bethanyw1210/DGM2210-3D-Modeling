using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothSpeed = 0.125f;
    public Vector3 offSet;

    public void LateUpdate()
    {
        Vector3 desiredPosition = player.position + offSet;
        Vector3 smoothedPosition = Vector3.Lerp(desiredPosition,transform.position, smoothSpeed);
        transform.position = desiredPosition;

        transform.LookAt(player);
    }
}
