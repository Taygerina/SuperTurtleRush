using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class automove : MonoBehaviour
{

    Rigidbody2D rb;
    public Vector2 direction;
    public float force = 1;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rb.AddForce(direction * force);
    }
}
