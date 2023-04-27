using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreChecker : MonoBehaviour
{

    public static ScoreChecker instance;
    public int score;

     private void Awake()
    {
        instance = this;
    }

    public void AddScore(int scores)
    {
        score += scores;
    }

    void Update()
    {
        if (score == 10)
        {
            SceneChange();
        }
    }

    private void SceneChange()
    {
        SceneManager.LoadScene("GameWorld");
    }
}
