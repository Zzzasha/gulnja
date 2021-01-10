using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameUI : MonoBehaviour
{
    public void BackToLevels()
    {
        SceneManager.LoadScene("Levels");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public string NextLevel;
    public void NextLlv()
    {
        SceneManager.LoadScene(NextLevel);
    }

}
