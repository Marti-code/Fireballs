using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{

    public void QuitToMain(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }
}
