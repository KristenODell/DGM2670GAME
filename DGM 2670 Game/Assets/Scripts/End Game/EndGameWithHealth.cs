using UnityEngine;
using System.Collections;

public class EndGameWithHealth : EndGameBase
{
    // Polymorphism
    // Inheritance
    public PlayerLife health;

    public override void Start ()
    {
        base.Start();
        UpdateFunction.EndGameHealth += EndGameHealthHandler;
    }

    public void EndGameHealthHandler ()
    {
        if(health.healthVariable <= 0)
        {
                StartCoroutine(EndGameScreen());
        }
    }
}
