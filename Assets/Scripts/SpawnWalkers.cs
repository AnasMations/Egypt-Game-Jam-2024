using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWalkers : MonoBehaviour
{
    public GameObject walkerPrefab;
    // private int count;
    // Update is called once per frame
    void Start()
    {
        
        StartCoroutine(Spawner());
    }

    IEnumerator Spawner()
    {

        WaitForSeconds wait = new WaitForSeconds(0.5f);
 
        for(int count = 0; count < 1000; count++) 
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-5, 5), 1, Random.Range(15, 20));

            Instantiate(walkerPrefab, randomSpawnPosition, Quaternion.identity);
            yield return wait; 

        }
    
        
    }


}
