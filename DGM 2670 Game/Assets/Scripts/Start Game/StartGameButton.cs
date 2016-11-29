using UnityEngine;
using System.Collections;

public class StartGameButton : MonoBehaviour, IStartGame
{
    public GameObject StartMenu;

	void Awake ()
    {
        Time.timeScale = 0;
	}
	
    public void StartGame()
    {
        Time.timeScale = 1;
        StartMenu.SetActive(false);
    }
}
