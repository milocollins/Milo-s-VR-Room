using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OnTriggerEnterWithTag : MonoBehaviour
{
    public UnityEvent WhenTriggered = new UnityEvent();
    public string itemTag;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Maybe...");
        if (other.CompareTag(tag))
        {
            Debug.Log("It Works!");
            WhenTriggered.Invoke();
        }
    }
}
