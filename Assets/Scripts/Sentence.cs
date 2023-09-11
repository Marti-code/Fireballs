using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sentence : MonoBehaviour
{
    public GameObject Sentences;
    public float sec = 5f;

    void Start()
    {
       StartCoroutine(LateCall());
    }

    IEnumerator LateCall()
    {
        yield return new WaitForSeconds(sec);
        Sentences.SetActive(true);
    }
}
