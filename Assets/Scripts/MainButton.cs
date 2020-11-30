using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainButton : MonoBehaviour
{
    public GameObject sellButton;
    public GameObject cookieNumbers;

    public static int cookiesBought;
    private bool firstPush = true;

    public void Start()
    {
        cookiesBought = 1;
    }

    public void BuyButton ()
    {
        GlobalCookies.cookieCount += cookiesBought;
        
        if (firstPush == true)
        {
            sellButton.SetActive(true);
            cookieNumbers.SetActive(true);
            firstPush = false;
        }
    }

}
