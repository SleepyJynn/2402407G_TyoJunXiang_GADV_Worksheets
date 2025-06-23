using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerForces : MonoBehaviour
{
    CharacterController controller;

    // Your variables used for moving the player
    public float moveSpeed = 5f;
    public float gravity = -9.81f;
    Vector3 velocity;

    // Code to set the radius and force of the explosion
    public float radius = 5.0F;
    public float power = 10000.0F;

    public float kickStrength = 500f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        controller.detectCollisions = false; // See comment about this!
    }

    void CheckExplosion()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
            foreach (Collider hit in colliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddExplosionForce(power, transform.position, radius, 1.0f, ForceMode.Impulse);
                }
            }
        }
    }

    void Kick()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Collider[] colliders = Physics.OverlapSphere(transform.position + transform.forward * 1.5f, 1.5f);
            foreach (Collider hit in colliders)
            {
                Rigidbody rb = hit.GetComponent<Rigidbody>();
                if (rb != null)
                {
                    rb.AddForce(transform.forward * kickStrength, ForceMode.Impulse);
                }
            }
        }
    }

    void FixedUpdate()
    {
        CheckExplosion();
        Kick();

        // Simple player movement
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 move = transform.right * moveX + transform.forward * moveZ;
        controller.Move(move * moveSpeed * Time.fixedDeltaTime);

        // Gravity
        velocity.y += gravity * Time.fixedDeltaTime;
        controller.Move(velocity * Time.fixedDeltaTime);
    }
}
