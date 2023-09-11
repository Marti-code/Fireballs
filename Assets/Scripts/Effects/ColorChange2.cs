using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange2 : MonoBehaviour
{
    private int counter = 0;
    public List<Color> colors;
    SpriteRenderer renderReference;

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (counter < colors.Count - 1)
        {
            counter++;
        }
        else
        {
            counter = 0;
        }
        renderReference.color = colors[counter];
    }

    void Start()
    {
        renderReference = GetComponent<SpriteRenderer>();
        renderReference.color = colors[counter];
    }
}
