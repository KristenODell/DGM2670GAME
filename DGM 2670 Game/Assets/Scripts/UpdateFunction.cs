using UnityEngine;
using System.Collections;
using System;

public class UpdateFunction : MonoBehaviour
{

	// Use this for initialization


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
    }
}
