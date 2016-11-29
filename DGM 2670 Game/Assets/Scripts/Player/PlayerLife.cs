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
        Health = HealthHandler;
        StaticVariables.originalHealth = health;
	}

    void OnTriggerEnter ()
    {
        health--;
        print("hit"); 
    }

    public void HealthHandler()
    {
        switch (health)
        {
            case 3:
                healthText.text = "Lives: 3";
                break;
            case 2:
                healthText.text = "Lives: 2";
                break;
            case 1:
                healthText.text = "Lives: 1";
                break;
            default:
                healthText.text = "Lives: 0";
                break;
        }
    }
}
