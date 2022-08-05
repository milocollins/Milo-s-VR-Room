using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordPlayer : MonoBehaviour
{
    private AudioSource myAudio;
    public AudioClip musicClip;
    public Transform record;
    public float originalRotationRate = 78;
    private float currentRotationRate = 0;

    private void Start()
    {
        myAudio = transform.GetComponent<AudioSource>();
        myAudio.clip = musicClip;
        myAudio.Play();
        currentRotationRate = originalRotationRate;
    }
    // Update is called once per frame
    void Update()
    {
        record.Rotate(0, currentRotationRate*Time.deltaTime, 0);
    }
    public void ToggleRecordPlayer()
    {
        Debug.Log("Plays Function");
        if (myAudio.clip !=null)
        {
            Debug.Log("Audio clip fine");
            if (myAudio.isPlaying)
            {
                myAudio.Pause();
                currentRotationRate = 0;
            }
            else
            {
                myAudio.UnPause();
                currentRotationRate = originalRotationRate;
            }
        }
    }
}
