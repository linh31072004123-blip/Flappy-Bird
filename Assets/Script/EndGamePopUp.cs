using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class EndGamePopUp : MonoBehaviour
{
    public Button btnClick;
    public TMP_Text tmpScoreCurrent;
    public TMP_Text tmpScoreBest;
    public void Init()
    {
        btnClick.onClick.AddListener(OnClick);
    }
    public void ShowScore()
    {
        tmpScoreCurrent.text = "Score: " + GamePlayController.Instance.scoreController.score.ToString();
        tmpScoreBest.text = "Best: " + PlayerPrefs.GetInt("Score", 0).ToString();
    }
    public void OnClick()
    {
        SceneManager.LoadScene("GamePlay");
    }
    
    
}
