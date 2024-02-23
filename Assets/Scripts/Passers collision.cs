using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using Unity.VisualScripting;

public class NewBehaviourScript : MonoBehaviour
{
    [SerializeField] Slider PeaceMeter;
    public UnityEvent OnLose;
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
        //After detecting the passers
        //We Check if they truly passers or not
        //Then We deduct from the peace meter
        //until the peace meter is depleted which we can know from the Lose condition.cs
        
        if (collider.CompareTag("Passers"))
        {
            // add rigidbody to the passer and push it back
            Rigidbody tempRB = collider.AddComponent<Rigidbody>();
            tempRB.useGravity = false;
            tempRB.AddForce(new Vector3(Random.Range(-1, 1), 1f, 0.5f) * 7f, ForceMode.Impulse);
            tempRB.AddTorque(new Vector3(Random.Range(-1, 1), Random.Range(-1, 1), Random.Range(-1, 1)) * 5f, ForceMode.Impulse);

            print("Hit Person");
            PeaceMeter.value = PeaceMeter.value - 0.1f;

            if (PeaceMeter.value <= 0)
            {
                OnLose?.Invoke();
                print("You Lose");
            }
        }
    }
}
