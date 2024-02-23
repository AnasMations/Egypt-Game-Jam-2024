using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedSpot : MonoBehaviour
{
    private MeshRenderer meshRenderer;
    private Material originalMaterial;
    public Material flashMaterial;

    private void Start()
    {
        // Assuming the MeshRenderer is on the same GameObject as this script
        meshRenderer = GetComponent<MeshRenderer>();

        // Store the original material for resetting
        originalMaterial = meshRenderer.material;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Flash white and lose PeaceMeter
            StartCoroutine(FlashAndLosePeaceMeter());
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // Reset to the original material
            meshRenderer.material = originalMaterial;
            StopAllCoroutines();
        }
    }

    IEnumerator FlashAndLosePeaceMeter()
    {


        // Lose PeaceMeter every second
        while (true)
        {
            // Flash white
            meshRenderer.material = flashMaterial;

            GLOBALSBalance.PeaceMeter -= 1;
            yield return new WaitForSeconds(0.10f);

            // Reset to the original material
            meshRenderer.material = originalMaterial;

            yield return new WaitForSeconds(0.05f);
        }
    }
}
