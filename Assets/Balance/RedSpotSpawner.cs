using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSpotSpawner : MonoBehaviour
{
    public GameObject[] redSpots;
    public float spawnInterval = 2f;

    // Start is called before the first frame update
    void Start()
    {
        // Deactivate all red spots
        foreach(GameObject redSpot in redSpots)
        {
            redSpot.SetActive(false);
        }

        // Start spawning objects after a delay (optional)
        InvokeRepeating("SpawnRedSpot", 0f, spawnInterval);
        InvokeRepeating("SpawnRedSpot", 1f, spawnInterval);
        InvokeRepeating("SpawnRedSpot", 1f, spawnInterval);
    }


    void SpawnRedSpot()
    {
        // Pick a random red spot and set active
        int randomIndex;
        do
        {
            randomIndex = Random.Range(0, redSpots.Length);
        }while(redSpots[randomIndex].activeSelf == true); // Keep picking a random index until we find an inactive red spot

        // Set the red spot active
        redSpots[randomIndex].SetActive(true);
        
        // Deactivate the red spot after a delay
        StartCoroutine(DeactivateRedSpot(redSpots[randomIndex], spawnInterval));
    }

    IEnumerator DeactivateRedSpot(GameObject redSpot, float delay)
    {
        yield return new WaitForSeconds(delay);
        redSpot.SetActive(false);
    }
}
