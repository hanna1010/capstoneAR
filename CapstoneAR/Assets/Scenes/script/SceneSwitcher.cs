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
    public void GotoGHGARmap()
    {
        SceneManager.LoadScene("GHGARmap");
    }

    public void GotoGHGARInfo()
    {
        SceneManager.LoadScene("GHGARInfo");
    }

    public void GotoGHGMap()
    {
        SceneManager.LoadScene("GHGMap");
    }

    public void GotoGHGFB()
    {
        SceneManager.LoadScene("GHGFB");

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
