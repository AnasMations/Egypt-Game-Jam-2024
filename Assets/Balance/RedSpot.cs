using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RedSpot : MonoBehaviour
{
    public void OnTriggerEnter (Collider other)
    {
        if(other.CompareTag("Player"))
        {
            // Lose peaceMeter every second
            StartCoroutine(LosePeaceMeter());
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            StopAllCoroutines();
        }
    }

    IEnumerator LosePeaceMeter()
    {
        while(true)
        {
            GLOBALSBalance.PeaceMeter -= 1;
            yield return new WaitForSeconds(0.15f);
        }
    }
}
