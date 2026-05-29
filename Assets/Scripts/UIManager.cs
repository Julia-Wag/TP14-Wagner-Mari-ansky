using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timerText;

    public GameObject winPanel;
    public GameObject gameOverPanel;

    public void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score;
    }

    public void UpdateTimer(float time)
    {
        timerText.text = "Time: " + time.ToString("F1");
    }

    public void MostrarPantallaWin()
    {
        winPanel.SetActive(true);
    }

    public void MostrarPantallaGameOver()
    {
        gameOverPanel.SetActive(true);
    }
}
