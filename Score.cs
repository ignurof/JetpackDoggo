using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score
{
    private int score;

    public int GetScore()
    {
        return score;
    }

    public void AddScore(int x)
    {
        score += x;
    }
}
