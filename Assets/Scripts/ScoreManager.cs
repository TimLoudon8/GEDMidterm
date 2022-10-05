using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    // Defining the instance
    public static ScoreManager instance;

    public int score = 0;

    //Creating the instance for the singleton
    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
    }

    // Changes the score and outputs it into the console
    public void ChangeScore(int collectibles, int livesLost)
    {
        score += collectibles;
        score -= livesLost;
        Debug.Log(score);
    }
}
