using UnityEngine;

public class LookAtBehaviour : MonoBehaviour
{
    public void OnLook(Vector3Data obj)
    {
        transform.LookAt(obj.value); 
        var transformRotation = transform.eulerAngles; 
        transformRotation.x = 0; 
        transformRotation.y -= 90; 
        transform.rotation = Quaternion.Euler(transformRotation); 
    }
}
