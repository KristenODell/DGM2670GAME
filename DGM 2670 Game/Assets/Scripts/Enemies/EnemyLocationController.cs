using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class EnemyLocationController : MonoBehaviour
{
    public List<Transform> HList;
    public List<Transform> HPositionList;
    public List<Transform> VList;
    public List<Transform> VPositionList;

    //public IEnumerator MovingEnemies()
    //{

    //}

    // Use this for initialization
    void Start()
    {
        HEnemyList.SendThis += AddHEnemy;
        SendToHEnemyPoint.SendThis += AddHPosition;
        VEnemyList.SendThis += AddVEnemy;
        SendToVEnemyPoints.SendThis += AddVPosition;
        Invoke("MoveStuff", .1f);
        Invoke("MoveStuff", 20);
        Invoke("MoveStuff", 50);
        Invoke("MoveStuff", 80);
    }

    void MoveStuff()
    {
        foreach (Transform i in HList)
        {
            int j = UnityEngine.Random.Range(0, HPositionList.Count - 1);
            i.position = HPositionList[j].position;
        }
        foreach (Transform i in VList)
        {
            int j = UnityEngine.Random.Range(0, VPositionList.Count - 1);
            i.position = VPositionList[j].position;
        }
    }


    void AddHPosition(Transform obj)
    {
        HPositionList.Add(obj);
    }

    void AddHEnemy(Transform obj)
    {
        HList.Add(obj);
    }

    void AddVPosition(Transform obj)
    {
        VPositionList.Add(obj);
    }

    void AddVEnemy(Transform obj)
    {
        VList.Add(obj);
    }
}
