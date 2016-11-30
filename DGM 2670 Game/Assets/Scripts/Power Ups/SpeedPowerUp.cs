using UnityEngine;
using System.Collections;

public class SpeedPowerUp : PowerUpBase
{
    public float speed;
    public float speedPowerUp;
    public float originalSpeed = 10;
    public float wait = 10;

    public IEnumerator IncreaseSpeed()
    {
        speed = speedPowerUp;
        yield return new WaitForSeconds(wait);
        speed = originalSpeed;
    }

    void Start ()
    {
        speed = StaticVariables.speed;
        speedPowerUp = StaticVariables.powerUpSpeed;
    }

    public override void OnTriggerEnter()
    {
        StartCoroutine(IncreaseSpeed());
        gameObject.SetActive(false);
    }

}
