using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CoinDisappear : MonoBehaviour
{
    public int wait = 5;
    public Transform coin;
    public Transform originalPosition;
    public Transform newPosition;

    void Start ()
    {
        //originalColor = gameObject.GetComponent<Renderer>().material.color;
    }

    public IEnumerator resetCoin()
    {
        //gameObject.layer = 9;
        //gameObject.GetComponent<Renderer>().material.color = newColor;
        coin.position = newPosition.position; 
        yield return new WaitForSeconds(wait);
        coin.position = originalPosition.position;
        //gameObject.layer = 8;
        //gameObject.GetComponent<Renderer>().material.color = originalColor;

    }

    void OnTriggerEnter()
    {
        StartCoroutine(resetCoin());
    }

}
