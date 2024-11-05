using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Score", menuName = "Stats/New Score")]
public class ScoreSO : ScriptableObject
{
    public float score, highscore;

    public DelegateFuncionSO onScoreChanged, onHighscoreChanged;

    public void IncreaseScore(float amount)
    {
        score += amount;

        CheckHighscore();

        onScoreChanged?.onFuncionCalled.Invoke();
    }

    public void ResetScore()
    {
        score = 0;

        onScoreChanged?.onFuncionCalled.Invoke();
    }

    public void CheckHighscore()
    {
        if (score > highscore)
        {
            highscore = score;

            onHighscoreChanged?.onFuncionCalled.Invoke();
        }
    }
}
