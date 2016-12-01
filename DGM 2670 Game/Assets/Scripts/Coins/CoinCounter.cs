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

    public void BiggerHandler()
    {
        switch (coins)
        {
            case 10:
                anim.SetBool("10Coins", true);
                break;
            case 20:
                anim.SetBool("20Coins", true);
                break;
            case 30:
                anim.SetBool("30Coins", true);
                break;
        }
    }
    
}
