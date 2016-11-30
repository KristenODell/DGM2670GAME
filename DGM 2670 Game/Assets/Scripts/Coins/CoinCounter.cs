using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class CoinCounter : MonoBehaviour
{
    public Text counter;
    public int coins = 0;

    private Animator anim;

    public static Action Bigger;

    void Start ()
    {
        counter.text = "Coins: " + coins;
        anim = GetComponent<Animator>();
        Bigger = BiggerHandler;
    }

    void OnTriggerEnter()
    {
        coins++;
        counter.text = "Coins: " + coins;
    }

    public void BiggerHandler ()
    {
        if(coins > 10)
        {
            anim.SetBool("10Coins", true);
        }
        if (coins > 20)
        {
            anim.SetBool("20Coins", true);
        }
    }
    
}
