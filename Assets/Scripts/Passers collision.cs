using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] ProgressBar PeaceMeter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    string collidertag = collision.gameObject.tag;
    //    print("hello");
    //    if (collidertag == "Passers")
    //    {
    //        print("hello");
    //        PeaceMeter.current = PeaceMeter.current - 5;
    //    }
    //}
    void OnCollisionEnter(Collision collision)
    {
        string collidertag = collision.gameObject.tag;
        if (collidertag == "Passers")
        {
            print("Hit Person");
            PeaceMeter.current = PeaceMeter.current - 5;
        }
    }
}
