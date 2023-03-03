using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveApple : MonoBehaviour
{
    Rigidbody2D rb;
    public int moveSpeed;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        rb.velocity = Vector3.left * moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
