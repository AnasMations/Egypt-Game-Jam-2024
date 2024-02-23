using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Losecondition lose;
    [SerializeField] Slider PeaceMeter;
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
        //After detecting the passers
        //We Check if they truly passers or not
        //Then We deduct from the peace meter
        //until the peace meter is depleted which we can know from the Lose condition.cs
        if (!lose.haslost)
        {
            string collidertag = collision.gameObject.tag;
            if (collidertag == "Passers")
            {
                print("Hit Person");
                PeaceMeter.value = PeaceMeter.value - 0.05f;
            }
        }
    }
}
