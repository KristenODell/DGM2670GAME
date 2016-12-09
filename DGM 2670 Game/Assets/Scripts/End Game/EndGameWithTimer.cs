using UnityEngine;
using System.Collections;

public class EndGameWithTimer : EndGameBase
{
    
    public override void Start ()
    {
        base.Start();
        UpdateFunction.EndGameTimer += EndGameTimerHandler;
    }

    public void EndGameTimerHandler (float time)
    {
        if(time <= 0)
        {
            StartCoroutine(EndGameScreen());
        }
    }	
}
