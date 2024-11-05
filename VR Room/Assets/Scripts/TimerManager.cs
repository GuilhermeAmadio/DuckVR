using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerManager : MonoBehaviour
{
    public float timer;

    public TMPro.TextMeshProUGUI timerUI;

    public UnityEvent onTimerEnd;

    private bool started, ended;

    public void StartTimer()
    {
        started = true;
        ended = false; 
        ScoreManager.instance.ResetScore();
    }

    private void Update()
    {
        if (started)
        {
            timer -= Time.deltaTime;
            UpdateUI();

            if (timer <= 0 && !ended)
            {
                started = false;
                Debug.Log("Timer acabou");
                ended = true;
                onTimerEnd?.Invoke();
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
