using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndGame : MonoBehaviour
{
    public GameObject EndScreen;

    public void EconomyButton()
    {
        gameObject.SetActive(false);
        EndScreen.SetActive(true);
        EndScreen.GetComponent<Animation>().Play("Fade");
        EndScreen.GetComponent<Animation>().Play("EndScroll");
    }

    public void EndTheGame ()
    {
        Application.Quit();
    }
}
