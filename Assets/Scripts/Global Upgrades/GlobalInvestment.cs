using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalInvestment : MonoBehaviour
{
    [Header("Inspector References")]
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public GameObject InvestStats;

    [HideInInspector] public int currentCash;
    public static int InvestCost = 10;
    public static bool buttonOff = false;
    private bool thresholdReached = false;
    private bool gateBool = true;

    void Update()
    {
        currentCash = GlobalCash.cashCount;

        if (currentCash >= (InvestCost * 0.5) && gateBool == true) //make the upgrade become visible when half the cost is reached
        {
            thresholdReached = true;
            gateBool = false; //so this only runs once
            fakeButton.SetActive(true);
        }

        if (thresholdReached == true)
        {
            if (MainButton.cookiesBought > 1)
            {
                InvestStats.GetComponent<Text>().text = MainButton.cookiesBought + " Cookies Per Click";
            }
            fakeText.GetComponent<Text>().text = "Invest in Cookie Stocks - $" + InvestCost;
            realText.GetComponent<Text>().text = "Invest in Cookie Stocks - $" + InvestCost;


            if (currentCash >= InvestCost) //button controls and visibility
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
