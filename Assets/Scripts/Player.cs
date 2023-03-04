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
        if (Input.GetKeyDown(KeyCode.Space) && !isGround)
        {
            rb.velocity = Vector3.up * jumpForce;

        }

        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        isGround = false;
        if (collision.gameObject.CompareTag("Apple"))
        {
            GameManager.instance.gameOver = true;
            GameManager.instance.SetActiveTrue();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        isGround = true;
    }
}
