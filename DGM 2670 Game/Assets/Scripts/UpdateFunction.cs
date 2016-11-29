using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class UpdateFunction : MonoBehaviour
{
    public Text healthText;
    public Text countdownTimer;

    void Start ()
    {

    }

	// Update is called once per frame
	void Update ()
    {
        PlayerMovement.PlayerMove(10);
        VerticalEnemyMovement.VerticalEnemyMove();
        EnemyMovement.HorizontalEnemyMove();
        PlayerLife.Health();
        Timer.Countdown(60);
    }
}
