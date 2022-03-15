using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cenarioinfinito : MonoBehaviour
{
    public float velocidadedocenario;

    private void Update()
    {
        MovimentarCenario();
    }

    private void MovimentarCenario()
    {
        Vector2 deslocamento = new Vector2(Time.time * velocidadedocenario, 0);
        GetComponent<Renderer>().material.mainTextureOffset = deslocamento;
    }
}
