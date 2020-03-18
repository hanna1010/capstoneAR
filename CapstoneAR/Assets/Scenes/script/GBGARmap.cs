using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GBGARmap : MonoBehaviour
{
    public Toggle GHMtoggle;
    public Toggle GJJtoggle;
    public Toggle GHRtoggle;
    public Toggle GNJtoggle;

    int GHM=0, GJJ=0, GHR=0, GNJ=0;

    public void ActiveToggle() 
    {
        if (GHMtoggle.isOn)
        {
            GHM = 1;
            Debug.Log("광화문");
        }

        if (GJJtoggle.isOn)
        {
            GJJ = 1;
            Debug.Log("근정전");
        }

        if (GHRtoggle.isOn)
        {
            GHR = 1;
        }

        if (GNJtoggle.isOn)
        {
            GNJ = 1;
        }


    }

    public void OnSubmit()
    {
        ActiveToggle();

        if (GHM == 1 && GHR == 1)
        {

            SceneManager.LoadScene("GHMGHR");
        }

        else if (GHM == 1 && GJJ == 1)
        {
            Debug.Log("광화문근정전");
            SceneManager.LoadScene("GHMGJJ");
        }

        else if (GHM == 1 && GNJ == 1)
        {
            SceneManager.LoadScene("GHMGNJ");
        }

        else if (GHR == 1 && GJJ == 1)
        {
            SceneManager.LoadScene("GHRGJJ");
        }

        else if (GHR == 1 && GNJ == 1)
        {
            SceneManager.LoadScene("GHRGNJ");
        }
        else if (GNJ == 1 && GJJ == 1)
        {
            SceneManager.LoadScene("GNJGJJ");
        }
    }
}
