using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public void exit()
    {
        SceneManager.LoadScene("gmae");
    }

    public void newgame()
    {
        SceneManager.LoadScene("hogue game");
    }
}
