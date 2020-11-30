using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCookies : MonoBehaviour
{
    //need to have a global system in place to keep trakc of how many cookies we have. 
    public static int cookieCount;
    public GameObject CookieDisplay;
    public int internalCookie;


    private void Start()
    {
        Cursor.visible = true;
    }
    private void Update()
    {
        internalCookie = cookieCount;
        CookieDisplay.GetComponent<Text>().text = internalCookie + "\n Cookies";
    }


}
