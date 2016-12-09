using UnityEngine;
using UnityEngine;
using System.Collections;
using System;

public class SendToHEnemyPoint : MonoBehaviour
{
    public static Action<Transform> SendThis;

    void Start()
    {
        SendThis(transform);
    }

}