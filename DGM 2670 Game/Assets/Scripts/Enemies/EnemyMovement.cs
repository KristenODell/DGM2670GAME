using UnityEngine;
using System.Collections;
using System;

public class EnemyMovement : MonoBehaviour, IMoveEnemy
{
    public float speed = 1;
    private Vector3 tempPos;

    //public static Action HorizontalEnemyMove;

    // Use this for initialization
    void Start()
    {
        UpdateFunction.MoveHEnemies += EnemyMoveHandler;
    }

    void OnTriggerEnter()
    {
        speed *= -1;
    }


    public void EnemyMoveHandler()
    {
        tempPos.x = speed * Time.deltaTime;
        transform.Translate(tempPos);
    }
}
