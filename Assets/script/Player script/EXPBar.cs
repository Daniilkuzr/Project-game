using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EXPBar : MonoBehaviour
{
    public Slider slider;
    public float maxEXP;



    public void SetEXP(float exp,float maxExp)
    {
        slider.value = exp;
        slider.maxValue = maxEXP;
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
