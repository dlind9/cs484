using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class barMeterScript : MonoBehaviour
{
    public int val;
    public int decVal;
    public Slider slider;
    // Start is called before the first frame update
    void Start()
    {
       // HungerBar.UpdateBar(100, 100);
    }

    // Update is called once per frame
    void Update()
    {
        slider.value -= decVal * Time.deltaTime;
    }

    public void updateBar()
    {
        slider.value += val;
    }
}
