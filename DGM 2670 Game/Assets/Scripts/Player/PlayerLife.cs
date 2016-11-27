using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public Text healthText;
    public int health = 3;

    public static Action Health;

	void Start ()
    {
        healthText = GetComponent<Text>();
        healthText.text = "Lives: " + health;
	}

    void HealthHandler ()
    {
        if (health > 0)
        {
            health--;
            healthText.text = "Lives: " + health;
        }
        else
        {
            health = 0;
            healthText.text = "Lives: " + health;
            SceneManager.LoadScene("Level One");

        }
        
    }

}
