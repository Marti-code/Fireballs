using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateEnemy : MonoBehaviour
{
    public float degreesPerSec = 180f;
    public GameObject particles;
    private Renderer render;
    [SerializeField]
    private Color otherColor = Color.white;
    [SerializeField]
    private AudioClip PlayerDeath;
    public GameObject DeathMenu;
    // Start is called before the first frame update
    void Start()
    {
        DeathMenu.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        float rotAmount = degreesPerSec * Time.deltaTime;
        float curRot = transform.localRotation.eulerAngles.z;
        transform.localRotation = Quaternion.Euler(new Vector3(0, 0, curRot + rotAmount));
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "player")
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