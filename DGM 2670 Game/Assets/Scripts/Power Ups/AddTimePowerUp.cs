using UnityEngine;
using System.Collections;

public class AddTimePowerUp : PowerUpBase
{
    public float addTime;

    void Start ()
    {
        addTime = StaticVariables.addTemps;
    }

    void OnTriggerExit()
    {
        addTime += StaticVariables.temps;
    }
}
