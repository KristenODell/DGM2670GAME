using UnityEngine;
using System.Collections;

public class PowerUpBase : MonoBehaviour
{
    public PlayerLife _playerLife;

    public virtual void OnTriggerEnter()
    {
        gameObject.SetActive(false);
        _playerLife.healthVariable = 3;
    }
}
