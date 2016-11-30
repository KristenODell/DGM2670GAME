using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class UpdateFunction : MonoBehaviour
{
    public Text healthText;
    public Text counter;
    public Text countdownTimer;
    public float temps;
    public float speed;

    void Start ()
    {
        temps = StaticVariables.temps;
        speed = StaticVariables.speed;
    }

	// Update is called once per frame
	void Update ()
    {
        temps -= Time.deltaTime;
        PlayerMovement.PlayerMove(speed);
        VerticalEnemyMovement.VerticalEnemyMove();
        EnemyMovement.HorizontalEnemyMove();
        PlayerLife.Health();
        Timer.Countdown(temps);
        //Bullet.Shooting(30);
        CoinCounter.Bigger();
    }
}
