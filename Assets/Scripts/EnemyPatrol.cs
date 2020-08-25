using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public Transform player;
    public float speed = 5f;
    public float range = 3.4f;
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Enemy.health>0)
        {
            float distToPlayer = Vector2.Distance(transform.position, player.position);
            if (distToPlayer < range)
            {
                Chase();
            }
            else
            {
                Stop();
            }
        }
    }

    private void Chase()
    {
        if (transform.position.x < player.position.x)
        {
            rb.velocity = new Vector2(speed, 0);
            transform.localScale = new Vector2(2, 2);
        }
        else if (transform.position.x > player.position.x)
        {
            rb.velocity = new Vector2(-speed, 0);
            transform.localScale = new Vector2(-2, 2);
        }
    }

    private void Stop()
    {
        rb.velocity = Vector2.zero;
    }
}
