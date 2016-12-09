using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public Text healthText;
    public int healthVariable;

    public static Action Health;

    public GameObject playerHalo;
    public float wait = 1;
    public int damageWait = 2;
    public int damage = 1;

    public IEnumerator damageHalo()
    {
        for (int i = 0; i < damageWait; i++)
        {
            playerHalo.SetActive(true);
            yield return new WaitForSeconds(wait);
        }
        playerHalo.SetActive(false);
    }

    void Start ()
    {
        Health= HealthHandler;
        healthVariable = StaticVariables.health;
        playerHalo.SetActive(false);
	}

    void OnTriggerEnter ()
    {
        healthVariable = StaticFunction.Subtract(healthVariable, damage);
        StartCoroutine(damageHalo());
    }

    public void HealthHandler()
    {
        if(healthVariable > 3)
        {
            healthVariable = 3;
        }
        if(healthVariable < 0)
        {
            healthVariable = 0;
        }

        switch (healthVariable)
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
            case 0:
                healthText.text = "Lives: 0";
                break;
        }
    }
}
