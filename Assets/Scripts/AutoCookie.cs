using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoCookie : MonoBehaviour
{
    public bool creatingCookie = false;
    public GameObject CookieNo;
    public GameObject ERCDYstats;
    public GameObject autoMarketStats;

    //public static int cookieIncrease = 1;
    [SerializeField] int intIncrease;
    [SerializeField] int autoPause = 1;

    
    void Update()
    {
        intIncrease = GlobalERCDY.autoCookiePerSecond + GlobalMarket.MktIncrease; //our Cookies Per Second is just both the CPS outputs combined. 
        if (creatingCookie == false)
        { 
            creatingCookie = true;
            CookieNo.SetActive(true);
            StartCoroutine(CreateTheCookie());
        }
    }


    IEnumerator CreateTheCookie ()
    {
        GlobalCookies.cookieCount += intIncrease;
        if (GlobalERCDY.autoCookiePerSecond >= 1)
        {
            ERCDYstats.GetComponent<Text>().text = GlobalERCDY.autoCookiePerSecond + " CPS from dividend yields";
        }
        if (GlobalMarket.MktIncrease >= 1)
        {
            autoMarketStats.GetComponent<Text>().text = GlobalMarket.MktIncrease + " CPS from strong market performance";
        }
        CookieNo.GetComponent<Text>().text = intIncrease + ""; //the "" is bit of a cheat, rather than going through the trouble of converting intIncrease to a string to display. 
        yield return new WaitForSeconds(autoPause);
        creatingCookie = false;
    }
}
