using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] [Range(0,20)] int jumpForce;
    [SerializeField] Animator animator;
    AudioSource jumpSound;
    private bool isGround;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
        jumpSound = GetComponent<AudioSource>();
       
    }

    
    void Update()
    {
        if (Input.GetMouseButton(0) && !isGround && !GameManager.instance.GameOver)
        {
            rb.velocity = Vector3.up * jumpForce;
            animator.SetBool("Jumping", true);
            jumpSound.Play();

        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Apple"))
        {
            GameManager.instance.GameOver = true;
            GameManager.instance.SetActiveTrue();
            animator.enabled = false;
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGround = false;
        animator.SetBool("Jumping", false);
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGround = true;
    }
}
