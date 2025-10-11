using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ScoreController : MonoBehaviour
{
    public TMP_Text textScore;
    public int score;
    public void Init()
    {

        score = 0;
        textScore.text = score.ToString();
    }


    // Update is called once per frame
    public void AddScore()
    {
        score++;
        textScore.text = score.ToString();
        PlayerPrefs.SetInt("Score", score);
    }
}
