using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile
{
    private float speed;

    // Constructor
    public Projectile()
    {
        speed = 10;
    }

    // Public method
    public void Fire()
    {
        if (speed > 0)
        {
            Debug.Log($"Firing projectile at speed {speed}");
        }
        else
        {
            Debug.Log("Cannot fire: speed too low");
            AutoFire();
        }
    }

    public void AutoFire()
    {
        speed = 100;
        Debug.Log("Speed as zero. AutoFire set speed to 100 and launched!");
    }
}
