using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveApple : MonoBehaviour
{
    [SerializeField] int moveSpeed;

    void Update()
    {
        if (!GameManager.instance.gameOver)
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }
      
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }

    
}
