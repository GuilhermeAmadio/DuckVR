using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    public ScoreSO scoreSO;

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

    public void Scored(int scoreAmount)
    {
        scoreSO.IncreaseScore(scoreAmount);
    }

    public void ResetScore()
    {
        scoreSO.ResetScore();
    }
}
