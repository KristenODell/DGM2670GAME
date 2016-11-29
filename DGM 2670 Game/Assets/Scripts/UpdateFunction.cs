using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class UpdateFunction : MonoBehaviour
{
    public Text healthText;
    public Text countdownTimer;
    public float temps = 60;

    void Start ()
    {

    }

	// Update is called once per frame
	void Update ()
    {
        temps -= Time.deltaTime;
        PlayerMovement.PlayerMove(10);
        VerticalEnemyMovement.VerticalEnemyMove();
        EnemyMovement.HorizontalEnemyMove();
        PlayerLife.Health();
        Timer.Countdown(temps);
    }
}
