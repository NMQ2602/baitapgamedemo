using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Bullet2 : MonoBehaviour
{
    public float flySpeed = 5f;
    public int damage = 1;

    void Update()
    {
        transform.Translate(Vector2.up * flySpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        EHealth enemy = collision.GetComponent<EHealth>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}

