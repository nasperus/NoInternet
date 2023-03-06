using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveApple : MonoBehaviour
{
    [SerializeField] int moveSpeed;
    [SerializeField] int moveSpeed110;
    [SerializeField] int moveSpeed300;

    void Update()
    {
        MoveObstacles();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(gameObject);
        }
    }

    private void MoveObstacles()
    {
        if (!GameManager.instance.gameOver && GameManager.instance.score < 110)
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }

        if (!GameManager.instance.gameOver && GameManager.instance.score > 110)
        {
            transform.position += Vector3.left * moveSpeed110 * Time.deltaTime;
        }

        if (!GameManager.instance.gameOver && GameManager.instance.score > 310)
        {
            transform.position += Vector3.left * moveSpeed300 * Time.deltaTime;
        }
    }
}
