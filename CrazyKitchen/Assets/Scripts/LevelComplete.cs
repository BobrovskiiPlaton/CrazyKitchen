using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LevelComplete : MonoBehaviour
{
    public TMP_Text[] scores;
    public int goal;
    public string nextScene;

    private int count;

    private void Update()
    {
        foreach (var score in scores)
        {
            int result;
            if (int.TryParse(score.text, out result) && result == goal)
                count++;
        }
        if(count == scores.Length)
            UnityEngine.SceneManagement.SceneManager.LoadScene(nextScene);
        count = 0;
    }
}
