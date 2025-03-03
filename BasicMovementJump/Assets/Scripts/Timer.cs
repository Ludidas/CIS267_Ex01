using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    private float time;
    private TMP_Text guiTime;
    //assigned via Unity editor
    public GameObject gameManager;
    private GameManager gm;
    // Start is called before the first frame update
    void Start()
    {
        gm= gameManager.GetComponent<GameManager>();
        time = 10;
        guiTime = GetComponent<TMP_Text>();
        updateGuiTime();
    }

    // Update is called once per frame
    void Update()
    {
        timerTick();

    }

    public void timerTick()
    {
        time-=Time.deltaTime;
        updateGuiTime();
        if (timeUp())
        {
            gm.setGameOver(true);
            updateGuiTime();
        }
    }

    public void updateGuiTime()
    {
        guiTime.text = "Time: " + time;
    }

    public bool timeUp()
    {
        if (time <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
