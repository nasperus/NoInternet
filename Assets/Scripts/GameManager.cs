using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    [SerializeField] GameObject gameOverTag;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI highScore;
    public bool GameOver { get; set; }
    public double Score { get; set; }
   

    private void Awake()
    {
        instance = this;

    
    }
    private void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
       
    }

    public void SetActiveTrue()
    {
        
        gameOverTag.SetActive(true);
    }
   

    public void IncreaseScore()
    {
        
        int parseInt = Convert.ToInt32(Score);
        scoreText.text = parseInt.ToString();
        Score += 0.1;

        if (parseInt > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", parseInt);
            
        }

    }

    public void GameOverButton()
    {
        SceneManager.LoadScene("Game");
    }

   
}
