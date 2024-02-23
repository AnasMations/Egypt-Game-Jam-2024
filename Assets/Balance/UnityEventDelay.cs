using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;

public class UnityEventDelay : MonoBehaviour
{
    [SerializeField] // Fix the typo here
    public UnityEventDelayClass[] events;

    void Start()
    {
        foreach (UnityEventDelayClass e in events)
        {
            StartCoroutine(InvokeEvent(e.delay, e.unityEvent));
        }
    }

    IEnumerator InvokeEvent(float delay, UnityEvent unityEvent)
    {
        yield return new WaitForSeconds(delay);
        unityEvent?.Invoke();
    }
}

[System.Serializable]
public class UnityEventDelayClass
{
    public float delay;
    public UnityEvent unityEvent;
}
