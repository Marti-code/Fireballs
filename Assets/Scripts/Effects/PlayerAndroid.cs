using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerAndroid : MonoBehaviour
{
    //variables
    public float RotSpeed = 300;
    private Rigidbody2D rb;
    
    void Update()
    {
        Quaternion rot = transform.rotation;
        float z = rot.eulerAngles.z;

        z -= CrossPlatformInputManager.GetAxis("Horizontal") * RotSpeed * Time.deltaTime;

        rot = Quaternion.Euler(0, 0, z);
        transform.rotation = rot;
    }
}
