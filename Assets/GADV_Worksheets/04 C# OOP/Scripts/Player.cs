using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

