﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class VEnemyList : MonoBehaviour
{
    public static Action<GameObject> SendThis;

    void Start()
    {
        if (SendThis != null)
        {
            SendThis(gameObject);
        }
    }
}
