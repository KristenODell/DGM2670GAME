using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class Timer : MonoBehaviour
{
    // Monobehaviour Awake
    public Text countdownTimer;

    void Awake ()
    {
        UpdateFunction.Countdown = CountdownHandler;
    }

    public void CountdownHandler(float temps)
    {
        if (temps >= 0)
        {
            countdownTimer.text = "Time Remaining: " + temps.ToString("f0");
        }
        else
        {
            countdownTimer.text = "Time Remaining: 0";
        }
    }
	
}
