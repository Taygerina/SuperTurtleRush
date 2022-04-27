using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class VidaTurtle : MonoBehaviour
{
    public int VidaMaxima;
    public int VidaAtual;
    public GameObject pnlGameOver;
    public TMP_Text txtLives;

    public void ReceberDano()
    {
        txtLives.text = VidaAtual.ToString();
        VidaAtual -= 1;

        if (VidaAtual <= 0)
        {
            GameOver();

        }

    }

    public void SetSLives(int value)
    {

    }

    private void GameOver()
    {
        Time.timeScale = 0;
        pnlGameOver.SetActive(true);
    }
}
