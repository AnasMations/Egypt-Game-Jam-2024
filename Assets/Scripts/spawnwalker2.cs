using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnWalker2 : MonoBehaviour
{
    public GameObject walkerPrefab;

    // Update is called once per frame
    void Start()
    {

        StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
    {

<<<<<<< Updated upstream
        WaitForSeconds wait = new WaitForSeconds(1.1f);
 
        for(int count = 0; count < 80; count++) 
=======
        WaitForSeconds wait = new WaitForSeconds(1f);

        for (int count = 0; count < 80; count++)
>>>>>>> Stashed changes
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-4, 4), 1, Random.Range(75, 60));

            Instantiate(walkerPrefab, randomSpawnPosition, Quaternion.identity);
            yield return wait;

        }


    }



}
