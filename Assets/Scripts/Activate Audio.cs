using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateAudio : MonoBehaviour
{
    // Gather the audioclips in a list\
    // make them play randomly when you come near a passer?
    bool playaudio;
    public List<AudioClip> audioclips;
    private AudioClip audioclip;
    private GameObject leobject;
    public GameObject player;
    bool isplaying;
    // Start is called before the first frame update
    void Start()
    {
       int audio = Random.Range(0, audioclips.Count+30);
       audioclip = audioclips[audio];
       leobject = gameObject;
        isplaying = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 myloc;
        Quaternion myrot;
        Vector3 hisloc;
        Quaternion hisrot;
        leobject.transform.GetPositionAndRotation(out myloc, out myrot);
        player.transform.GetPositionAndRotation(out hisloc, out hisrot);
        float dist = Vector3.Distance(myloc,hisloc);
        if (dist <= 5 && !isplaying)
        {
            isplaying = true;
            AudioSource.PlayClipAtPoint(audioclip, myloc);
        }
    }

    
}
