﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Levels : MonoBehaviour
{
    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    } 

    public void FirstLevel()
    {
        SceneManager.LoadScene("FirstLevel");
    }

}
