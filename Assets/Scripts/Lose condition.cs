using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Losecondition : MonoBehaviour
{
    [SerializeField] Slider PeaceMeter;
    public bool haslost;

    // Start is called before the first frame update
    void Start()
    {
        haslost = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Checks whether the peace meter is depleted or not
        if (PeaceMeter.value == 0)
        {
            haslost = true;
            lost(haslost);
        }

    }
    void lost(bool haslost)
    {
        if (haslost)
        {
            print("Damn you suck");
            //Lose condition
        }
    }
}
