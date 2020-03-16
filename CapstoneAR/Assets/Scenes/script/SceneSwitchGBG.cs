using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitchGBG : MonoBehaviour
{
    
    public void GotoGBGARmap()
    {
        SceneManager.LoadScene("GBGARmap");
    }

    public void GotoGBGARInfo()
    {
        SceneManager.LoadScene("GBGARInfo");
    }

    public void GotoGBGMap()
    {
        SceneManager.LoadScene("GBGMap");
    }

    public void GotoGBGFB()
    {
        SceneManager.LoadScene("GBGFB");

    }
}
