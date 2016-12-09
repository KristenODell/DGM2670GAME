using UnityEngine;
using System.Collections;
using System;

public class VEnemyList : MonoBehaviour
{
    public static Action<Transform> SendThis;

    void Start()
    {
        SendThis(transform);
    }

}
