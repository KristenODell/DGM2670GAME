using UnityEngine;
using System.Collections;
using System;

public class HEnemyList : MonoBehaviour
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
