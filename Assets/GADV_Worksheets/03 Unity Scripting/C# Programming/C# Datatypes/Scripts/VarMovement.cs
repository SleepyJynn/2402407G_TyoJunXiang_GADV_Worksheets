using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        var speed = 5.0f; // Inferred as float
        var direction = new Vector3(1, 0 ,0); // Inferred as Vector3

        transform.position += direction * speed * Time.deltaTime;

        // speed = "fast";
    }
}
