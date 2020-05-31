using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToGHM : MonoBehaviour
{
    public void GotoGHM()
    {
        Debug.Log("print");
        SceneManager.LoadScene("GHM");
    }
    
}
