using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private ObstacleSpawner obstacleSpawner;

    public GameObject pnlGameOver;
    public GameObject pnlGamewon;
    public TMP_Text txtLives;

    public GameObject Player;


    int Score = 0;
    int Lives = 3;

    private void Start()
    {

        obstacleSpawner.StartRoutine();
    }

    public void SetScore(int value)
    {
        Score += value;
        if (Lives >= 40)
        {
            Destroy(Player.gameObject);
            obstacleSpawner.StopRoutine();

            pnlGamewon.SetActive(true);

        }
    }

    public void SetSLives(int value)
    {
        Lives -= value;
        txtLives.text = Lives.ToString();

        if (Lives <= 0)
        {
            Destroy(Player.gameObject);
            GameOver();
        }
    }

    public void MyLoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    private void GameOver()
    {
        obstacleSpawner.StopRoutine();

        pnlGameOver.SetActive(true);
    }
}
