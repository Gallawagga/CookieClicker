using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SellCookie : MonoBehaviour
{
    
    public GameObject statusBox;
    public GameObject cashDisplay;

    public static int cookieValue = 1;

    private bool firstPush = true;

    public void SellButton ()
    {
        if (GlobalCookies.cookieCount == 0)
        {
            statusBox.GetComponent<Text>().text = "YOU ARE COOKIE BROKE";
            statusBox.GetComponent<Animation>().Play("Cookieless");
        }
        else
        {

            GlobalCookies.cookieCount -= 1;
            GlobalCash.cashCount += cookieValue;

            if (firstPush == true)
            {
                cashDisplay.SetActive(true);
                firstPush = false;
            }
        }
    }

    public void SellTenButton ()
    {
        if (GlobalCookies.cookieCount < 10)
        {
            statusBox.GetComponent<Text>().text = "WE POSSESS BUT MEAGRE PORTIONS";
            statusBox.GetComponent<Animation>().Play("Cookieless");
        }
        else
        {
            GlobalCookies.cookieCount -= 10;
            GlobalCash.cashCount += (cookieValue * 10);

        }

    }

}
