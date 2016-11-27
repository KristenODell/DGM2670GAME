using UnityEngine;
using System.Collections;
using System;

public class VerticalEnemyMovement : MonoBehaviour, IMoveEnemy
{
    public float speed = 1;
    private Vector3 tempPos;

    public static Action VerticalEnemyMove;

    // Use this for initialization
    void Start()
    {
        VerticalEnemyMove = EnemyMoveHandler;
    }

    void OnTriggerEnter()
    {
        speed *= -1;
    }


    public void EnemyMoveHandler()
    {
        tempPos.z = speed * Time.deltaTime;
        transform.Translate(tempPos);
    }
}
