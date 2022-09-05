using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public bool gameStarted = false;

    [SerializeField] private GameObject player;
    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text livesText;


    private int lives = 2;
    private int score = 0;

    private void Awake()
    {
        instance = this;
    }

    private void Update()
    {
        scoreText.text = "Score: " + score.ToString();
        livesText.text = "Lives: " + lives.ToString();
    }

    public void StartGame()
    {
        gameStarted = true;
    }

    public void GameOver()
    {
        player.SetActive(false);
        Invoke("ReloadLevel", 1f);
    }

    public void ReloadLevel()
    {
        SceneManager.LoadScene("Game");
    }

    public void UpdateLives()
    {
        if (lives <= 0)
        {
            GameOver();
        }
        else
        {
            lives--;
            print("lives : " + lives);
        }
    }

    public void UpdateScore()
    {
        score++;
        print("Score : " + score);
    }
 }
