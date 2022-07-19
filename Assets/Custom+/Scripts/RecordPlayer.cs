using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordPlayer : MonoBehaviour
{
    private AudioSource myAudio;
    public AudioClip musicClip;
    public Transform record;
    public float rotationRate;

    private void Start()
    {
        myAudio = transform.GetComponent<AudioSource>();
        myAudio.clip = musicClip;
        myAudio.Play();
    }
    // Update is called once per frame
    void Update()
    {
        record.Rotate(0, rotationRate*Time.deltaTime, 0);
    }
    public void ToggleRecordPlayer()
    {
        if (myAudio.clip !=null)
        {
            if (myAudio.isPlaying)
            {
                myAudio.Pause();
            }
            else
            {
                myAudio.UnPause();
            }
        }
    }
}
