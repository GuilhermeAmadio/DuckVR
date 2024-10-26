using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public int score;

    public TMPro.TextMeshProUGUI scoreUI;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    private void Start()
    {
        UpdateUI();
    }

    public void Scored(int scoreAmount)
    {
        score += scoreAmount;

        UpdateUI();
    }

    public void UpdateUI()
    {
        scoreUI.text = "Score: " + score;
    }

    public void ResetScore()
    {
        score = 0;
    }
}
