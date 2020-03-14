using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GBGmap : MonoBehaviour
{
    public Toggle GHMtoggle;
    public Toggle GJJtoggle;
    public Toggle GHRtoggle;
    public Toggle GNJtoggle;

    public void ActiveToggle() 
    {
        if (GHMtoggle.isOn && GJJtoogle.isOn)
        {
            SceneManager.LoadScene("GHM-GJJ");
        }

        else if (GHMtoggle.isOn && GHRtoogle.isOn)
        {
            SceneManager.LoadScene("GHM-GHR");
        }

        else if (GHRtoggle.isOn && GJJtoogle.isOn)
        {
            SceneManager.LoadScene("GHR-GJJ");
        }

        else if (GHRtoggle.isOn && GNJtoogle.isOn)
        {
            SceneManager.LoadScene("GHR-GNJ");
        }

        else if (GNJtoggle.isOn && GJJtoogle.isOn)
        {
            SceneManager.LoadScene("GNJ-GJJ");
        }

        else
        {
            SceneManager.LoadScene("GHM-GJJ");
        }

    }

    public void OnSubmit()
    {
        ActiveToggle();
    }
}
