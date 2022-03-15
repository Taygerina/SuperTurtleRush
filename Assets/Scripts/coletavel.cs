using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coletavel : MonoBehaviour
{
    public int score = 1;
    public GameObject fx;

    public UIManager uimanager;

    private void Start()
    {
        uimanager = FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {

        if (other.CompareTag("Player"))

        {
            uimanager.SetScore(1);
            Instantiate(fx, transform.position, Quaternion.identity);

            Destroy(gameObject);
        }
        
    }

}