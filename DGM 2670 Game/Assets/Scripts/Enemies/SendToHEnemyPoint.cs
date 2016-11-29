using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class SendToHEnemyPoint : MonoBehaviour
{
    public List<GameObject> hEnemies;


    void AddToList(GameObject _go)
    {
        hEnemies.Add(_go);
    }

    void Start()
    {
        VEnemyList.SendThis += AddToList;
    }
}