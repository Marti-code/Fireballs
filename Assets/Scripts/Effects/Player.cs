using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float RotSpeed = 360f;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Quaternion rot = transform.rotation;
            float z = rot.eulerAngles.z;
            
            z -= Input.GetAxis("Horizontal") * RotSpeed * Time.deltaTime;

            rot = Quaternion.Euler(0, 0, z);
            transform.rotation = rot;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Quaternion rot = transform.rotation;
            float z = rot.eulerAngles.z;

            z -= Input.GetAxis("Horizontal") * RotSpeed * Time.deltaTime;

            rot = Quaternion.Euler(0, 0, z);
            transform.rotation = rot;
        }
    }
    void LeftRotate() // Lol to mi obraca kamerę ale tak zajebiście!!!! Ale na razie tylko w pierwszym levelu bo tu podłączyłam skrypt do kamery 
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Quaternion rot = transform.rotation;
            float z = rot.eulerAngles.z;

            z -= Input.GetAxis("Horizontal") * RotSpeed * Time.deltaTime;

            rot = Quaternion.Euler(0, 0, z);
            transform.rotation = rot;
        }
    }
}
