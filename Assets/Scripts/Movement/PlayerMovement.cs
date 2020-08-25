using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 40f;
    float horizontalMove = 0f;
    bool jump = false; bool crouch = false;

    public float health = 100f;
    public Animator anim;

    void Update()
    {
        if (health <= 0)
        {
            anim.SetBool("Dead", true);
        }

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetAxisRaw("Horizontal") != 0)
        {
            anim.SetBool("Walk", true);
        }
        else
        {
            anim.SetBool("Walk", false);
        }

        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
            anim.SetTrigger("Jump");
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
            anim.SetBool("Crouch",true);
        } 
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
            anim.SetBool("Crouch", false);
        }
    }

    private void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.deltaTime, crouch, jump);
        jump = false;
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        anim.SetTrigger("Hurt");
    }
}
