using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour
{

    public GameObject playerHalo;
    public float wait = 1;
    public int damageWait = 2;

    public IEnumerator damageHalo()
    {
        for (int i = 0; i < damageWait; i++)
        {
            playerHalo.SetActive(true);
            yield return new WaitForSeconds(wait);
        }
        playerHalo.SetActive(false);
    }

    void Start ()
    {
        playerHalo.SetActive(false);
    }
	
    void OnTriggerEnter ()
    {
        StartCoroutine(damageHalo());
        print("ouch");
    }

}
