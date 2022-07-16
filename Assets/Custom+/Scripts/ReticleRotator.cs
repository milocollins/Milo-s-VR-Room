using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleRotator : MonoBehaviour
{
    public float rotationRate = 2f;

    void Update()
    {
        transform.Rotate(0, rotationRate*Time.deltaTime, 0, Space.World);
    }
}
