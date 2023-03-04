using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveApple : MonoBehaviour
{
    [SerializeField] int moveSpeed;

    void Update()
    {
       transform.position += Vector3.left * moveSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }
}
