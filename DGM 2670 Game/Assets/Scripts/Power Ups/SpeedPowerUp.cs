using UnityEngine;
using System.Collections;

public class SpeedPowerUp : PowerUpBase
{
    // While Loop
    // 2 Coroutines
    // Polymorphism
    // Inheritance
    public float speedPowerUp = 20;
    public float originalSpeed = 15;
    public float wait = 1;

    public UpdateFunction speed;

    public IEnumerator IncreaseSpeed()
    {
        int i = 1;
        while (i > 0)
        {
            speed.speed = 20;
            yield return new WaitForSeconds(wait);
            i--;
        }
        speed.speed = 15;
    }

    public IEnumerator Waiting ()
    {
        StartCoroutine(IncreaseSpeed());
        yield return new WaitForSeconds(wait);
        base.OnTriggerEnter();
    }


    public override void OnTriggerEnter()
    {
        
        StartCoroutine(Waiting());

    }

}
