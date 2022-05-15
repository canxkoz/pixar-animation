using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiManager : MonoBehaviour
{
    public GameObject allUI;
    public aniSpeedViewer aniSpeedGui;
    public fpsCounter fpsGui;
    private bool uiIsOn = true;

    public void uiSwitch()
    {
        if (uiIsOn)
        {
            allUI.SetActive(false);
            aniSpeedGui.enabled = false;
            fpsGui.enabled = false;
            uiIsOn = false;
        }
           
        else
        {
            allUI.SetActive(true);
            aniSpeedGui.enabled = true;
            fpsGui.enabled = true;
            uiIsOn = true;
        }
            
    }
}
