using UnityEngine;

public class CamMovement : MonoBehaviour{   
    public Transform target;
    public float smoothSpeed = 0.3f;
    public Vector3 offset;

    void FixedUpdate(){
        Vector3 desirePosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desirePosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}