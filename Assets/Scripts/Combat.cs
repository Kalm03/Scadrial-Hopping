using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Combat : MonoBehaviour
{
    public Animator anim;
    public Transform attackPoint;
    public float range = 0.5f;
    public LayerMask enemylayers;
    public float damage=50;
    public float pewterMult = 2f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Attack();
        }
    }

    void Attack()
    {
        anim.SetTrigger("Attack");
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(attackPoint.position, range, enemylayers);
        foreach(Collider2D enemy in hitEnemies)
        {
            enemy.GetComponent<Enemy>().TakeDamage(damage);
            if(VarStorage.pewter)
                enemy.GetComponent<Enemy>().TakeDamage(damage*pewterMult);
        }
            
    }
}
