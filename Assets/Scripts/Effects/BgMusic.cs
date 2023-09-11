using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgMusic : MonoBehaviour
{
    private static BgMusic Bg;

    private void Awake()
    {
        if (!Bg)
            Bg = this;
        else
            Destroy(this.gameObject);

        DontDestroyOnLoad(transform.gameObject);
    }
}
