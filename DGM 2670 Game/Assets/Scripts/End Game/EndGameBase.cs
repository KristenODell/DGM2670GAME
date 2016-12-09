using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class EndGameBase : MonoBehaviour
{
    public GameObject gameOver;
    public Canvas endGame;
    public int waitForAnimation = 1;
    public int gameOverScreentime = 3;
    public Text countdown;
    public GameObject player;
    public Text lives;
    public Text coins;

    public IEnumerator EndGameScreen()
    {
        for (int i = 0; i < gameOverScreentime; i++)
        {
            gameOver.SetActive(true);
            countdown.enabled = false;
            player.SetActive(false);
            lives.enabled = false;
            coins.enabled = false;
            yield return new WaitForSeconds(waitForAnimation);
        }
        gameOver.SetActive(false);
        endGame.enabled = true;
    }

    public virtual void Start ()
    {
        gameOver.SetActive(false);
        endGame.enabled = false;
    }
    	
}
