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
    private double score = 0;
    public bool gameOver = false;
    private void Awake()
    {
        instance = this;

    
    }


    public void SetActiveTrue()
    {
        gameOverTag.SetActive(true);
    }
   

    public void IncreaseScore()
    {
        
        int parseInt = Convert.ToInt32(score);
        scoreText.text = parseInt.ToString();
        score += 0.1;
        

    }

    public void GameOverButton()
    {
        SceneManager.LoadScene("Game");
    }
}
