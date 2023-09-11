using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private float speed = 5.0f;
    public GameObject particles;
    private Renderer render;
    [SerializeField]
    private Color otherColor = Color.white;
    [SerializeField]
    private AudioClip PlayerDeath;
    public GameObject DeathMenu;

    public void Start ()
    {
        DeathMenu.gameObject.SetActive(false);
    }

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
        if (this.tag == "enemy2")
        {
            speed = 3.0f;
        }
        if (this.tag == "enemy3")
        {
            speed = 7.0f;
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag=="player")
        {
            AudioSource.PlayClipAtPoint(PlayerDeath, Camera.main.transform.position, 50.0f);
            Instantiate(particles, transform.position, Quaternion.identity);
            render = GetComponent<Renderer>();
            render.material.color = otherColor;
            Destroy(other.gameObject);
            DeathMenu.gameObject.SetActive(true);
        }
    }

}
