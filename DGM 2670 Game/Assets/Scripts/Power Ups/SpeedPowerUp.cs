using UnityEngine;
using System.Collections;

public class SpeedPowerUp : PowerUpBase
{
    public float speedPowerUp = 20;
    public float originalSpeed = 10;
    public float wait = 1;
    //public float speed = 10;

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
        speed.speed = 10;
    }

    public IEnumerator Waiting ()
    {
        StartCoroutine(IncreaseSpeed());
        yield return new WaitForSeconds(wait);
        base.OnTriggerEnter();
    }

    void Start ()
    {
        //speed = StaticVariables.speed;
        //speedPowerUp = StaticVariables.powerUpSpeed;
        //originalSpeed = StaticVariables.speed;
        //speed = 10;
    }

    public override void OnTriggerEnter()
    {
        
        StartCoroutine(Waiting());

    }

}
