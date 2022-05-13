using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aniSpeedCntrller : MonoBehaviour
{
    public Animator lampAnimator;
    public Slider aniSpeedSlider;
    public Text sliderText;
    void Update()
    {
        int sliderValue = (int)aniSpeedSlider.value;
        sliderText.text = sliderValue.ToString();
        float aniSpeed = aniSpeedSlider.value * 0.1f;
        lampAnimator.speed = aniSpeed;
        if (lampAnimator.speed != aniSpeed)
            lampAnimator.speed = aniSpeed;
    }
}
