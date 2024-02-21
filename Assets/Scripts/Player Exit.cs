using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerExit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        string collidertag = collision.gameObject.tag;
        if (collidertag == "Exit")
        {
            print("HitExit");
            //Transition to the next level
        }
    }
}
