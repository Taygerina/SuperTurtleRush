using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  

public class Respiraçãobar : MonoBehaviour
{
    public Slider respiraSlider;
    public int qntrespi = 10;
    float tmprespi;
    public GameObject Player;

    public GameObject pnlGameOver;





    void Start()
    {
        respiraSlider.value = qntrespi;
        respiraSlider.maxValue = qntrespi;
        tmprespi = qntrespi;
    }


    
}
