using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    Vector2 direction;
    public float force = 1;
    public Animator anim;
    public float TamanhoMinimo = 1, TamanhoMaximo = 10;
    public float tamanho;

    void OnGui()
    {
        tamanho = GUI.HorizontalSlider(new Rect(Screen.width / 2 - Screen.width / 2.5f, Screen.height / 2 - Screen.height / 2.5f, Screen.width / 8, Screen.height / 14), tamanho, TamanhoMinimo, TamanhoMaximo);
    }

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tamanho = TamanhoMinimo;
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

        transform.localScale = new Vector3(tamanho, tamanho, tamanho);

    }
}