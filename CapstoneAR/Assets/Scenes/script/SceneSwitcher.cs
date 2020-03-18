using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public void GotoMap()
    {
        SceneManager.LoadScene("Map");
    }

    public void GotoStart()
    {
        Debug.Log("work");
        SceneManager.LoadScene("Start");
    }

    public void GotoGBG()
    {
        SceneManager.LoadScene("GBG");
    }

    public void GotoGHG()
    {
        SceneManager.LoadScene("GHG");
    }
  
    public void GotoCDG()
    {
        SceneManager.LoadScene("CDG");
    }

    public void GotoCGG()
    {
        SceneManager.LoadScene("CGG");
    }

    public void GotoDSG()
    {
        SceneManager.LoadScene("DSG");
    }
}
