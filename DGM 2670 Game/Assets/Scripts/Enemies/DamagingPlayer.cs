using UnityEngine;
using System.Collections;

public class DamagingPlayer : MonoBehaviour
{
    public PlayerLife health;
    public int damage = 0;
	
    void OnTriggerEnter()
    {
        health.healthVariable = StaticFunction.Subtract(health.healthVariable, damage);
    }
}
