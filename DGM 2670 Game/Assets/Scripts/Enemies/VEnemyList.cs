using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class VEnemyList : MonoBehaviour
{
    public List<SendToVEnemyPoints> recycleList;
    private Vector3 movePos;

    void SendThisHandler(SendToVEnemyPoints _r)
    {
        recycleList.Add(_r);
    }

    void Start()
    {
        recycleList = new List<SendToVEnemyPoints>();
        SendToVEnemyPoints.SendThis += SendThisHandler;
    }
}
