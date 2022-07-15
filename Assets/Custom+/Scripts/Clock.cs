using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    private Transform secondHand;
    private Transform minuteHand;
    private Transform hourHand;
    private DateTime currentTime;
    void Awake()
    {
        secondHand = transform.GetChild(3);
        minuteHand = transform.GetChild(2);
        hourHand = transform.GetChild(1);
    }

    void Start()
    {
        currentTime = DateTime.Now;
        MoveHands();
    }

    void Update()
    {
        if (currentTime.Second != DateTime.Now.Second)
        {
            currentTime = DateTime.Now;
            MoveHands();
        }
    }

    private void MoveHands()
    {
        //Set Seconds Hand
        secondHand.localRotation = Quaternion.Euler(90 + currentTime.Second * 6, 0f, -90f);
        //Set Minute Hand
        minuteHand.localRotation = Quaternion.Euler(90 + currentTime.Minute * 6, 0f, -90f);
        //Set Hour Hand
        hourHand.localRotation = Quaternion.Euler(90 + currentTime.Hour * 30 + currentTime.Minute * 0.5f, 0f, -90f);
    }
}
