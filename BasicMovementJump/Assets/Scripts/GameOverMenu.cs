using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    //drag and drop connection through unity
    public GameObject gameManager;
    public GameObject gameOverMenu;
    private GameManager gm;

    
    void Start()
    {
        gm = gameManager.GetComponent<GameManager>();
    }

    void Update()
    {
        if(gm.getGameOver()==true)
        {
            showGameOverMenu();
        }
    }

    public void showGameOverMenu()
    {
        gameOverMenu.SetActive(true);
    }

    public void exitGame()
    {
        Application.Quit();
    }

    public void restartGame()
    {
        gm.setGameOver(false);
        gameOverMenu.SetActive(false);
        SceneManager.LoadScene("SampleScene");
    }


}
