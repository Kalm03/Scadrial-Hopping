using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public static float health = 100f;
    public Animator anim;
    public GameObject bodyLight;

    private void Update()
    {
        if(health <= 0)
        {
            anim.SetBool("Dead", true);
            bodyLight.SetActive(false);
            this.enabled = false;
        }

        if (VarStorage.tin)
        {
            bodyLight.SetActive(true);
        }
        else
            bodyLight.SetActive(false);
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        anim.SetTrigger("Hurt");
    }
}
