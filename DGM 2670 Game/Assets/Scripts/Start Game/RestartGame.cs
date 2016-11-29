using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour, IStartGame
{

	// Use this for initialization
	void Start ()
    {
	
	}
	
    public void StartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Level One");
    }
}
