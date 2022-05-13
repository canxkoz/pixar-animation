using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class targetFrameRate : MonoBehaviour
{
    private int target = 60;
    public Slider targetChanger;
    public Text sliderText;

    void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = target;
    }

    void Update()
    {
        int sliderValue = (int)targetChanger.value;
        target = sliderValue;
        sliderText.text = sliderValue.ToString();
        if (Application.targetFrameRate != target)
            Application.targetFrameRate = target;
    }
}
