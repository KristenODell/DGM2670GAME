using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class CoinCounter : MonoBehaviour, ICoin
{
    // Switch Statement
    // Monobehaviour OnTriggerEnter
    // Interface
    public Text counter;
    public int coins = 0;
    private Animator anim;


    public void Start ()
    {
        counter.text = "Coins: " + coins;
        anim = GetComponent<Animator>();
        UpdateFunction.Bigger += BiggerHandler;
    }

    public void OnTriggerEnter()
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
