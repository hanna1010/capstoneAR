using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
   
    public void GotoStart()
    {
        SceneManager.LoadScene("Start");
    }

    public void GotoGBG()
    {
        SceneManager.LoadScene("GBG");
    }

    public void GotoGBGARmenu()
    {
        SceneManager.LoadScene("GBGARmenu");
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
