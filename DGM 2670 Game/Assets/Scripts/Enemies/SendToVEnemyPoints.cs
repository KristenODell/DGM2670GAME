using UnityEngine;
using System.Collections;
using System;

public class SendToVEnemyPoints : MonoBehaviour
{
    public static Action<Transform> SendThis;

    void Start()
    {
        SendThis(transform);
    }

}
