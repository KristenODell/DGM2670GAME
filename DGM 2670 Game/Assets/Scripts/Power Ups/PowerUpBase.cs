using UnityEngine;
using System.Collections;

public class PowerUpBase : MonoBehaviour
{
    // Inheritance
    public virtual void OnTriggerEnter()
    {
        gameObject.SetActive(false);
    }
}
