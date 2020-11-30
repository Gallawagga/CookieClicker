using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoCookie;
    public static int ERCDYincrease = 1;

    public void StartAutoCookie()
    {
        AutoCookie.SetActive(true);
        GlobalCash.cashCount -= GlobalERCDY.ERCDYvalue;
        GlobalERCDY.ERCDYvalue += 25;

        GlobalERCDY.autoCookiePerSecond += 1;
    }

    public void CookieInvestment() //increase amount of cookies gained per click by one. 
    {
        MainButton.cookiesBought += 1;
        GlobalCash.cashCount -= GlobalInvestment.InvestCost;
        GlobalInvestment.InvestCost += 10;
    }

    public void CookieMarket()
    {
        GlobalCash.cashCount -= GlobalMarket.marketCost;
        GlobalMarket.marketCost *= 2;
        //double the value of cookies in cash
        SellCookie.cookieValue *= 2;
        //increase the amount of auto cookies per second by one. 
        GlobalMarket.MktIncrease += 1;
    }
}
