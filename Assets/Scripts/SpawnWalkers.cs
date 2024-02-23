using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWalkers : MonoBehaviour
{
    public GameObject walkerPrefab;
    public GameObject Win;

    void Start()
    {


        StartCoroutine(Spawner());
        StartCoroutine(Timer());
    }

    IEnumerator Spawner()
    {

        WaitForSeconds wait = new WaitForSeconds(0.85f);

        for (int count = 0; count < 80; count++)
        {
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-5, 5), 1, Random.Range(15, 20));

            Instantiate(walkerPrefab, randomSpawnPosition, Quaternion.identity);
            yield return wait;

        }


    }

    IEnumerator Timer()
    {

        WaitForSeconds wait = new WaitForSeconds(60f);
        yield return wait;

        Time.timeScale = 0f;
        Win.SetActive(true);





    }
}
