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

    public static Action MoveVEnemies;
    public static Action MoveHEnemies;
    public static Action Bigger;
    public static Action<float> Countdown;
    public static Action<float> PlayerMove;
    public static Action<float> EndGameTimer;
    public static Action EndGameHealth;

    void Start ()
    {
        temps = StaticVariables.temps;
    }

	// Update is called once per frame
	void Update ()
    {
        temps -= Time.deltaTime;
        PlayerMove(speed);
        PlayerLife.Health();
        Countdown(temps);
        Bigger();
        if (MoveVEnemies != null)
        {
            MoveVEnemies();
        }
        MoveHEnemies();
        EndGameTimer(temps);
        EndGameHealth();
    }
}
