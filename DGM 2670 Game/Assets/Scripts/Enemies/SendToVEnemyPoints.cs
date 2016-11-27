using UnityEngine;
using System.Collections;
using System;

public class SendToVEnemyPoints : MonoBehaviour
{
    public static Action<SendToVEnemyPoints> SendThis;

    void Start()
    {
        if (SendThis != null)
        {
            SendThis(this);
        }
    }
}
