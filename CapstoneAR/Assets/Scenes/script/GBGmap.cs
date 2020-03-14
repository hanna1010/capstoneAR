using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Text.RegularExpressions;

public class GBGmap : MonoBehaviour
{
    public Toggle toggle;
    void start()
    {
        toggle.onValueChange.Invoke(false);
    }

    public void toggle_Changed(bool newValue) 
    {
        
    }
}
