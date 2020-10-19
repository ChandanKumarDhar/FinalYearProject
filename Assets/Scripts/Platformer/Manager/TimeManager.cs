using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeManager : MonoBehaviour
{
    public static TimeManager Instance { get; private set; }

    public float TimerTime { get; private set; }

    private bool timerRunning = false;

    private void Awake()
    {
        Instance = this;
        TimerTime = 0;
    }

    private void Update()
    {
        if (timerRunning)
        {
            TimerTime += Time.deltaTime;
        }
    }

    public void StartTimer()
    {
        timerRunning = true;
    }

    public void PauseTimer()
    {
        timerRunning = false;
    }

    public void ResetTimer()
    {
        TimerTime = 0f;
    }

}
