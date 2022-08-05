using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chomper : MonoBehaviour
{
    public AudioClip crunch;

    private AudioSource myAudio;

    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        if (myAudio == null)
        {
            Debug.Log("Audio Source not found");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Food"))
        {
            Eat(other.gameObject);
        }
    }
    public void Eat(GameObject food)
    {
        Destroy(food);
        myAudio.PlayOneShot(crunch);
    }
}
