using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 direction;
    public float force = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        direction = new Vector2(hor, ver);

        rb.AddForce(direction * force);
    
    }
}
