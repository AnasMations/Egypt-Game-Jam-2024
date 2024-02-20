using UnityEngine;

public class RandomRotator : MonoBehaviour
{
    public float minRotationDuration = 1f;
    public float maxRotationDuration = 5f;
    public float rotationLimit = 25f;

    private float targetRotation;
    private float rotationVelocity;

    private void Start()
    {
        // Initial rotation speed and duration
        SetRandomRotation();
    }

    private void Update()
    {
        // Rotate the cube around the local z-axis
        float smoothedSpeed = Mathf.SmoothStep(-rotationLimit, rotationLimit, Mathf.PingPong(Time.time * rotationSpeed, 1f));
        transform.Rotate(Vector3.forward * smoothedSpeed * Time.deltaTime);

        // Smoothly adjust the rotation towards the targetRotation
        float currentRotation = Mathf.SmoothDampAngle(transform.localEulerAngles.z, targetRotation, ref rotationVelocity, 0.3f);
        transform.localEulerAngles = new Vector3(0f, 0f, currentRotation);

        // Check if it's time to change rotation parameters
        rotationTimer -= Time.deltaTime;
        if (rotationTimer <= 0f)
        {
            SetRandomRotation();
        }
    }

    private float rotationSpeed;
    private float rotationTimer;

    private void SetRandomRotation()
    {
        // Generate random rotation speed and duration
        rotationSpeed = Random.Range(minRotationDuration, maxRotationDuration);
        rotationTimer = Random.Range(minRotationDuration, maxRotationDuration);

        // Set a new target rotation within the limit
        targetRotation = Random.Range(-rotationLimit, rotationLimit);
    }
}
