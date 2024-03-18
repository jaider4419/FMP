using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public float distance = 5.0f; 
    public float height = 3.0f; 
    public float smoothSpeed = 5.0f; 

    private Vector3 offset; 

    void Start()
    {

        offset = transform.position - target.position;
    }

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset.normalized * distance;
        desiredPosition.y = target.position.y + height;

        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothedPosition;

        transform.LookAt(target);
    }
}
