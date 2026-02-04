using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EAttack : MonoBehaviour
{
    public EHealth health;
    public int damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        var playerHealth = collision.GetComponent<PHealth>();
        if (playerHealth != null)
        {
            playerHealth.TakeDamage(damage);
            health.TakeDamage(1000);
        }
    }
}

