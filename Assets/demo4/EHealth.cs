using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EHealth : Health
{
    protected override void Die()
    {
        base.Die();
        Debug.Log("Enemy died");
    }
}

