using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CoinDisappear : MonoBehaviour, ICoin
{
    public int wait = 1;
    public Transform coin;
    public Transform originalPosition;
    public Transform newPosition;


    public IEnumerator resetCoin()
    {
        int i = 10;
        while (i > 0)
        {
            coin.position = newPosition.position;
            yield return new WaitForSeconds(wait);
            i--;
        }
        coin.position = originalPosition.position;
    }

    public void Start ()
    {
        print("Coin is going to disappear");
    }

    public void OnTriggerEnter()
    {
        StartCoroutine(resetCoin());
    }

}
