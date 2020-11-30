using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalEconomy : MonoBehaviour
{
    [Header("Inspector References")]
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;

    [Header("In-game numbers")]
    public int currentCash;
    public static int EcoValue = 500;

    private bool thresholdReached = false;
    public static bool gateBool = true;


    void Update()
    {
        if (gateBool == true)
        {
            currentCash = GlobalCash.cashCount;

            if (currentCash >= (EcoValue * 0.5))
            {
                thresholdReached = true;
                fakeButton.SetActive(true);
            }

            if (thresholdReached == true)
            {
                fakeText.GetComponent<Text>().text = "??????????? - $" + EcoValue;
                realText.GetComponent<Text>().text = "MOVE TO A COOKIE-BASED ECONOMY - $" + EcoValue;


                if (currentCash >= EcoValue)
                {
                    fakeButton.SetActive(false);
                    realButton.SetActive(true);
                }
            }
        }
    }
}
