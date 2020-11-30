using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{

    //need to have a global system in place to keep trakc of how many cookies we have. 
    public static int cashCount;

    public static bool cookieEconomy = false;

    public GameObject CashDisplay;
    public int internalCash;

    private void Update()
    {
        internalCash = cashCount;
        CashDisplay.GetComponent<Text>().text = "CASH: $" + internalCash;
        
        if(Input.GetKeyDown("p"))
        {
            cashCount += 100;
        }
    }

    public void KickStartEconomy ()
    {

    }



}
