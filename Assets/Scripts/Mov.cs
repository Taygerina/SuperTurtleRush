using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 direction;
    public float force = 1;
    public Animator anim; 


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float ver = Input.GetAxis("Vertical");
        float hor = Input.GetAxis("Horizontal");

        if(Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("Cima", true);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetBool("Cima", false);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("baixo", true);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetBool("baixo", false);
        }


        direction = new Vector2(hor, ver);

        rb.AddForce(direction * force);
    
    }
}
