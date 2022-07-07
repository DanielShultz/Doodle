using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI ScoreLayout;

    public static int MaxScore = 0;
    public static int CurrentScore = 0;

    private void Start()
    {
        NewScore(0);
    }

    public void NewScore(int value)
    {
        CurrentScore = 0;
        if (value > MaxScore)
        {
            MaxScore = value;
        }
        ScoreLayout.text = "Score: " + value;
    }
}
