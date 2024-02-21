using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSounds : MonoBehaviour
{
    public AudioSource _as;
    public AudioClip[] audioClipArray;


    void Awake()
    {
        _as = GetComponent<AudioSource>();
    }
    // Start is called before the first frame update
    void Start()
    {
        _as.clip = audioClipArray[Random.Range(0,30)];
        _as.PlayOneShot (_as.clip); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
