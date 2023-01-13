using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SliderScript : MonoBehaviour
{
    [SerializeField] Slider slider;
    public void SetMaxSliderValue(float SliderValue)
    {
        slider.maxValue = SliderValue;
        slider.value = SliderValue;
    }

    public void SetSliderValue(float SliderValue)

    {
        slider.value = SliderValue;
    }

}