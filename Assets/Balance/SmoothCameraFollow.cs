using UnityEngine;

public class SmoothCameraFollow : MonoBehaviour
{
    public Transform target;          // The target to follow (e.g., the player)
    public float smoothSpeed = 5f;    // Smoothing factor for camera movement

    void LateUpdate()
    {
        if (target != null)
        {
            // Calculate the desired rotation for the camera (only follow z-axis rotation)
            Quaternion desiredRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, target.rotation.eulerAngles.z);

            // Smoothly rotate the camera towards the desired rotation
            transform.rotation = Quaternion.Lerp(transform.rotation, desiredRotation, smoothSpeed * Time.deltaTime);
        }
    }
}
