using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bolha : MonoBehaviour
{

    
    public Slider respiraSlider;
    public int qntrespi = 10;
    float tmprespi;
    public GameObject Player;
    public GameObject pnlGameOver;
    

    private void Start()
    {
    
        respiraSlider.value = qntrespi;
        respiraSlider.maxValue = qntrespi;
        tmprespi = qntrespi;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))

        {
            respiraSlider.value += 2;
 

            Destroy(gameObject);
        }

    }

    void Update()
    {
        tmprespi -= Time.deltaTime;
        respiraSlider.value = tmprespi;
        

        if (respiraSlider.value <= 0)
        {
            Destroy(Player.gameObject);
            GameOver();

        }
        
    }

    private void GameOver()
    {

        pnlGameOver.SetActive(true);
    }

    

}