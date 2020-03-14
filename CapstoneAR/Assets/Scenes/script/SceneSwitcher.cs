using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    // Start is called before the first frame update
    public void GotoStart()
    {
        SceneManager.LoadScene("Start");
    }

    // Update is called once per frame
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
