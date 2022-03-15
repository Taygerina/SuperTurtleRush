using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public string nomedacena;

    public void NovoJogo()
    {
        SceneManager.LoadScene(nomedacena);
    }

}
