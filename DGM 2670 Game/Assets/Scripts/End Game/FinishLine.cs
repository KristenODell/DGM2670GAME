using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class FinishLine : EndGameBase
{
    // Monobehaviour OnTriggerExit

	void OnTriggerExit ()
    { 
        StartCoroutine(EndGameScreen());

	}

}
