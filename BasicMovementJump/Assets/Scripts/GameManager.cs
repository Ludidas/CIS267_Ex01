using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private bool gameOver;
    public GameObject Player;
    private PlayerScore playerScore;

    private void Start()
    {
        playerScore = Player.GetComponent<PlayerScore>();
        Debug.Log("High Score: " + SaveData.loadScore());
        setGameOver(false);
    }

    public bool getGameOver(){return gameOver;}

    public void setGameOver(bool g)
    { 
        gameOver = g; 
        evaluateGameState();
    }

    public void evaluateGameState()
    {
        if (gameOver)
        {
            SaveData.saveScore(playerScore.getScore());
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }

    }
}
