using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Catcher : MonoBehaviour
{

    private float speed = 3.0f;
    public string scenename;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
        {
            SceneManager.LoadScene(scenename);
        }
    }
}
