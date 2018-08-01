using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightSliderController : MonoBehaviour {
    public Light lt;

    void Start()
    {
        lt = GetComponent<Light>();
    }

    public void changeIntensity(Slider slider)
    {
        lt.intensity = slider.value;
    }
}
