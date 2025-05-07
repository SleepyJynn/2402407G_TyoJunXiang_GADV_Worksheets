using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GADVDataTypes
{
    public class SpriteScaler : MonoBehaviour
    {
        private Transform spriteTransform;
        private string scale = "2.0a";
        // Start is called before the first frame update
        void Start()
        {
            spriteTransform = GetComponent<Transform>();

            int parsedScale = int.Parse(scale);

            spriteTransform.localScale = new Vector3(parsedScale, parsedScale, 1f);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}