using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidColourTinter : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Access the SpriteRenderer component
            SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

            if (spriteRenderer.color == Color.blue)
            {
                spriteRenderer.color = Color.white;
            }
            else
            {
                // Change the color to blue
                spriteRenderer.color = Color.blue;
            }
        }
    }
}

