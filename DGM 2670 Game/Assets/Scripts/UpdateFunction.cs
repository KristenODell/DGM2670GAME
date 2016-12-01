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
    //public SpeedPowerUp _speedPowerUp;

    void Start ()
    {
        temps = StaticVariables.temps;
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
