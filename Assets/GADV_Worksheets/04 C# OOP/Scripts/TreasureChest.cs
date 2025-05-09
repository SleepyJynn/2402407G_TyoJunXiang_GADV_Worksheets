using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureChest
{
    // Virtual method: can be overridden by subclasses
    public virtual void Unlock()
    {
        Debug.Log("You unlock the chest.");
    }

    // Non-virtual method: cannot be overridden
    public void Shake()
    {
        Debug.Log("You hear something rattle inside the chest.");
    }

    public void Unlock(bool hasToken)
    {
        if (hasToken == true)
        {
            Debug.Log("You unlock the chest with bonus treasure.");
        }
    }
}

// Subclass 1
public class AncientChest : TreasureChest
{
    public override void Unlock()
    {
        Debug.Log("You unlock the ancient chest with an ancient key.");
    }
}

// Subclass 2
public class MagicChest : TreasureChest
{
    public override void Unlock()
    {
        Debug.Log("You cast a spell to unlock the magic chest.");
    }
}
