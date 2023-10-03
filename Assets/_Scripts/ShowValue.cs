using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowValue : MonoBehaviour
{
    // take the slider as an input
    // take the text value and assign the slider to it
    public Slider slider;
    public Text text;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        string sliderValue = slider.value.ToString("#.##"); ;



        text.text = sliderValue;
    }
}
