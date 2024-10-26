using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerManager : MonoBehaviour
{
    public float timer;

    public TMPro.TextMeshProUGUI timerUI;

    private bool started;

    private void Start()
    {
        StartTimer();
    }

    public void StartTimer()
    {
        started = true;
    }

    private void Update()
    {
        if (started)
        {
            timer -= Time.deltaTime;
            UpdateUI();

            if (timer <= 0)
            {
                started = false;
                Debug.Log("Timer acabou");
                //timer end
            }
        }
    }
    
    private void UpdateUI()
    {
        int timerInt = Mathf.RoundToInt(timer);
        timerUI.text = "Timer: " + timerInt.ToString();
    }
}
