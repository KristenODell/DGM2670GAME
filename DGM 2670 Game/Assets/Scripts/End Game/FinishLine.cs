using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FinishLine : EndGameBase
{


	void OnTriggerExit ()
    { 
        StartCoroutine(EndGameScreen());

	}

}
