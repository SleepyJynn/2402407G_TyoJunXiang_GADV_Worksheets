using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class Main : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

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
public class Player
{
    private int health;

    public Player()
    {
        health = 10;
    }

    public void TakeDamage(int amount)
    {
        health -= amount;
    }

    public void GetHealth()
    {
        Debug.Log("Current Health is: " + health);
    }
}

public class ScoreTracker
{
    private int score;

    public void ResetScore()
    {
        score = 0;
    }
}

public class TreasureChest
{
    // Virtual method: can be overridden by subclasses
    public virtual void Unlock()
    {
        Console.WriteLine("You unlock the chest.");
    }

    // Non-virtual method: cannot be overridden
    public void Shake()
    {
        Console.WriteLine("You hear something rattle inside the chest.");
    }
}

// Subclass 1
public class AncientChest : TreasureChest
{
    public override void Unlock()
    {
        Console.WriteLine("You unlock the ancient chest with an ancient key.");
    }
}

// Subclass 2
public class MagicChest : TreasureChest
{
    public override void Unlock()
    {
        Console.WriteLine("You cast a spell to unlock the magic chest.");
    }
}
