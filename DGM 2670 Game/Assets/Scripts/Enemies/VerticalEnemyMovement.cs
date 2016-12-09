using UnityEngine;
using System.Collections;
using System;

public class VerticalEnemyMovement : MonoBehaviour, IMoveEnemy
{
    public float speed = 1;
    private Vector3 vtempPos;

    //public static Action VerticalEnemyMove;

    // Use this for initialization
    void Start()
    {
        UpdateFunction.MoveVEnemies += EnemyMoveHandler;
    }

    void OnTriggerEnter()
    {
        speed *= -1;
    }


    public void EnemyMoveHandler()
    {
        vtempPos.z = speed * Time.deltaTime;
        transform.Translate(vtempPos);
    }
}
