using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void ChangeScreen(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void Quit()
    {
        Debug.Log("You quit");
        Application.Quit();
    }
}
