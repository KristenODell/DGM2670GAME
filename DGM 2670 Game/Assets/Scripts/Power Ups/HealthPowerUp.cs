using UnityEngine;
using System.Collections;

public class HealthPowerUp : PowerUpBase
{
    public PlayerLife _playerLife;

    public override void OnTriggerEnter ()
    {
        _playerLife.healthVariable = 3;
        base.OnTriggerEnter();
    }
}
