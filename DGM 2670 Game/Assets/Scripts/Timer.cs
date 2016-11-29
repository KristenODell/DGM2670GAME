using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class Timer : MonoBehaviour
{
    public Text countdownTimer;
    public static Action<float> Countdown;
    //public float temps = 60;

    void Awake ()
    {
        Countdown = CountdownHandler;
    }

    public void CountdownHandler(float temps)
    {
        temps -= Time.deltaTime;
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
