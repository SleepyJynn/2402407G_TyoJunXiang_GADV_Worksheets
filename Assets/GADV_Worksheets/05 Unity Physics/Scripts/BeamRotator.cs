using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeamRotator : MonoBehaviour
{
    public float torqueForce = 50f; // Set this in Inspector
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.maxAngularVelocity = 100f; // Optional: allows faster rotation
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            // Clockwise (around Y axis)
            rb.AddTorque(Vector3.down * torqueForce, ForceMode.Impulse);
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {
            // Anti-clockwise (around Y axis)
            rb.AddTorque(Vector3.up * torqueForce, ForceMode.Impulse);
        }
    }
}
