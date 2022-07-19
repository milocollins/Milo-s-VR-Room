using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TennisBall : MonoBehaviour
{
    private AudioSource myAudio;
    public AudioClip bounceSound;
    private Rigidbody rb;
    private bool timer = false;
    void Start()
    {
        myAudio = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(rb.velocity.magnitude + ", " + collision.transform.name);
        float v = rb.velocity.magnitude;
        if (v > 1 && !timer)
        {
            if (v < 5)
            {
                myAudio.volume = rb.velocity.magnitude / 5;
            }
            else
            {
                myAudio.volume = 1f;
            }
            myAudio.PlayOneShot(bounceSound);
            timer = true;
            StartCoroutine(Timer());
        }
    }
    private IEnumerator Timer()
    {
        timer = true;
        yield return new WaitForSeconds(0.1f);
        timer = false;
    }
}
