﻿using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class SendToVEnemyPoints : MonoBehaviour
{
    public List<GameObject> vEnemies;


    void AddToList(GameObject _go)
    {
        vEnemies.Add(_go);
    }

    void Start()
    {
        VEnemyList.SendThis += AddToList;
    }
}
