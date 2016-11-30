using UnityEngine;
using System.Collections;

public class Damage : MonoBehaviour
{

    public GameObject playerHalo;
    public float wait = 2;

    public IEnumerator damageHalo()
    {
        playerHalo.SetActive(true);
        yield return new WaitForSeconds(wait);
        playerHalo.SetActive(false);
    }

    void Start ()
    {
        playerHalo.SetActive(false);
    }
	
    void OnCollisionEnter ()
    {
        StartCoroutine(damageHalo());
    }

}
