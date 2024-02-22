using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walker2move : MonoBehaviour
{
    void Update()
    {
        // Move the object forward along its z axis 1 unit/second.
        transform.Translate((4 * -Vector3.forward) * Time.deltaTime);
            }
    public void OnTriggerEnter(Collider collider)
    {

        Destroy(this.gameObject);

    }
}
