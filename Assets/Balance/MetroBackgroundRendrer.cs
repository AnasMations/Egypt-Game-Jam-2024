using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetroBackgroundRendrer : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Transform spawnPoint;
    public float moveSpeed = 5f;
    public float spawnInterval = 2f;

    private void Start()
    {
        // Start spawning objects after a delay (optional)
        InvokeRepeating("SpawnAndMoveObject", 0f, spawnInterval);
    }

    private void SpawnAndMoveObject()
    {
        // Spawn a new object
        GameObject spawnedObject = Instantiate(objectToSpawn, spawnPoint.position, Quaternion.identity);

        // Move the spawned object to the left
        MoveObjectToLeft(spawnedObject);

        // Destroy the old object after a delay
        Destroy(spawnedObject, spawnInterval);
    }

    private void MoveObjectToLeft(GameObject obj)
    {
        Rigidbody rb = obj.GetComponent<Rigidbody>();

        if (rb != null)
        {
            rb.AddForce(Vector3.left * moveSpeed, ForceMode.VelocityChange);
        }
        else
        {
            Debug.LogError("Rigidbody component not found on the spawned object.");
        }
    }
}
