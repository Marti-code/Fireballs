using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewBehaviourScript : MonoBehaviour
{
    public static int SceneIndex;

    void Start()
    {
        if(SceneIndex == 0)
        {
            StartCoroutine(Intro());
        }
    }
    IEnumerator Intro ()
    {
        yield return new WaitForSeconds(4);
        SceneIndex = 1;
        SceneManager.LoadScene(1);
    }
}
