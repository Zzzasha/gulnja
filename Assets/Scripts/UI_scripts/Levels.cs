using System.Collections;
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
    public void SecondLevel()
    {
        SceneManager.LoadScene("SecondLevel");
    }
    public void ThirdLevel()
    {
        SceneManager.LoadScene("ThirdLevel");
    }

    public void tutor1()
    {
        SceneManager.LoadScene("tutor1");
    }

    public void tutor2()
    {
        SceneManager.LoadScene("tutor2");
    }

    public void tutor3()
    {
        SceneManager.LoadScene("tutor3");
    }


}
