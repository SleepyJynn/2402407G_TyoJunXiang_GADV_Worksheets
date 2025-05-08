using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GADVDataTypes
{
    public class VarExample : MonoBehaviour
    {
        // Start is called before the first frame update
        void Start()
        {
            // Inferred as SpriteRenderer
            var sprite = GetComponent<SpriteRenderer>();

            // Inferred as Color
            var spriteColor = sprite.color;

            // Inferred as Vector2
            var spriteSize = sprite.bounds.size;

            Debug.Log("Sprite Color: " + spriteColor);
            Debug.Log("Sprite Size: " + spriteSize);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}