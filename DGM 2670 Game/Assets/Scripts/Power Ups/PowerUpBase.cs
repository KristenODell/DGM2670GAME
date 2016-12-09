using UnityEngine;
using System.Collections;

public class PowerUpBase : MonoBehaviour
{

    public virtual void OnTriggerEnter()
    {
        gameObject.SetActive(false);
    }
}
