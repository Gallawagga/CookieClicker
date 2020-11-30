using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMarket : MonoBehaviour
{
    [Header("Inspector References")] //variables for the upgrade icon, and whether it is visible to the player.
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public GameObject marketStats;

    [HideInInspector] public int currentCash;
    public static int marketCost = 100;
    private bool thresholdReached = false;
    private bool gateBool = true;

    public static int MktIncrease;

    void Update()
    {
        currentCash = GlobalCash.cashCount;

        if (currentCash >= (marketCost * 0.5) && gateBool == true) //making the buttons visible
        {
            thresholdReached = true;
            gateBool = false;
            fakeButton.SetActive(true);
        }

        if (thresholdReached == true)
        {
            if (SellCookie.cookieValue > 1)
            {
                marketStats.GetComponent<Text>().text = "CURRENT COOKIE VALUATION - 1:" + SellCookie.cookieValue;
            }
            fakeText.GetComponent<Text>().text = "Strengthen the Cookie's Valuation - $" + marketCost;
            realText.GetComponent<Text>().text = "Strengthen the Cookie's Valuation - $" + marketCost;

            if (currentCash >= marketCost) //if there isn't enough money to buy
            {
                fakeButton.SetActive(false);
                realButton.SetActive(true);
            }
            else
            {
                fakeButton.SetActive(true);
                realButton.SetActive(false);
            }
        }
    }
}
