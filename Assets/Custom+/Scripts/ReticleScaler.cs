using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleScaler : MonoBehaviour
{
    
    public float scaleRate = 2f;
    public float scaleDeviation = 1;
    private Vector3 originalScale;

    private void Start()
    {
        originalScale = transform.localScale;
    }
    // Update is called once per frame
    void Update()
    {
        if (ScalingCheck())
        {
            if (scaleRate > 0)
            {
                transform.localScale = new Vector3(originalScale.x + scaleDeviation, originalScale.y, originalScale.z + scaleDeviation);
            }
            else
            {
                transform.localScale = new Vector3(originalScale.x - scaleDeviation, originalScale.y, originalScale.z - scaleDeviation);
            }
            scaleRate = -scaleRate;
        }
        transform.localScale += new Vector3(scaleRate, 0f, scaleRate)*Time.deltaTime;
    }
    private bool ScalingCheck()
    {
        if (transform.localScale.x > originalScale.x + scaleDeviation || transform.localScale.x < originalScale.x - scaleDeviation)
        {
            return true;
        }
        return false;
    }
}
