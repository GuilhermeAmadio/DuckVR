using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUI : MonoBehaviour
{
    public ScoreSO scoreSO;

    public TMPro.TextMeshProUGUI score, highscore;

    public DelegateFuncionSO onScoreChanged, onHighscoreChanged;

    private void ChangeScore()
    {
        score.text = "Score: " + scoreSO.score.ToString();
    }

    private void ChangeHighscore()
    {
        highscore.text = "Highscore: " + scoreSO.highscore.ToString();
    }

    private void OnEnable()
    {
        if (onScoreChanged != null)
        {
            onScoreChanged.onFuncionCalled += ChangeScore;
        }

        if (onHighscoreChanged != null)
        {
            onHighscoreChanged.onFuncionCalled += ChangeHighscore;
        }
    }

    private void OnDisable()
    {
        if (onScoreChanged != null)
        {
            onScoreChanged.onFuncionCalled -= ChangeScore;
        }

        if (onHighscoreChanged != null)
        {
            onHighscoreChanged.onFuncionCalled -= ChangeHighscore;
        }
    }
}
