using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHealth : Health
{
    protected override void Die()
    {
        base.Die();
        Debug.Log("Player died");
        FindObjectOfType<GameManager>().GameOver();
    }

}

