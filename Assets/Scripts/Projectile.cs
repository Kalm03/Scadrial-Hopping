using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rb;
    public LayerMask whatIsSolid;
    public float distance;
    public static float damage = 5f;
    public LayerMask enemyLayers;
    private bool touchGround = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb.velocity = Vector2.zero;

        if (collision.gameObject.CompareTag("Pickup"))
        {
            TurningClip.numClips = 1;
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            touchGround = true;
        }
        else
        {
            touchGround = false;
        }
    }
}
