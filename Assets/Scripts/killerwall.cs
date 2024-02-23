using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class killerwall : MonoBehaviour
{

    private float speed;
    void Awake()
    {
        speed = Random.Range(2.0f, 6f);
    }
    void Update()
    {


        // Move the object forward along its z axis 1 unit/second.
        transform.Translate((speed * Vector3.forward) * Time.deltaTime);
    }
    public void OnTriggerEnter(Collider collider)
    {

        Destroy(this.gameObject);

    }


}