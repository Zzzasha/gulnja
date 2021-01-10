using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject ball;
    public GameObject UI;
    public GameObject GameOverScr;

    public void Start()
    {
        UI.SetActive(true);
        GameOverScr.SetActive(false);
    }

    public void FixedUpdate()
    {
        if(ball == null)
        {
            UI.SetActive(false);
            GameOverScr.SetActive(true);
        }
    }
}
