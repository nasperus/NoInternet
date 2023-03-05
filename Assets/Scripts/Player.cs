using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] [Range(0,20)] int jumpForce;
    private bool isGround;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isGround)
        {
            rb.velocity = Vector3.up * jumpForce;

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
            GameManager.instance.gameOver = true;
            GameManager.instance.SetActiveTrue();
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGround = false;

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGround = true;
    }
}
