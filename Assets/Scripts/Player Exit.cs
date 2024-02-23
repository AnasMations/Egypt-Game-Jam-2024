using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerExit : MonoBehaviour
{
    public UnityEvent OnExit;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Exit"))
        {
            OnExit?.Invoke();
            print("HitExit");
            //Transition to the next level
        }
    }
}
