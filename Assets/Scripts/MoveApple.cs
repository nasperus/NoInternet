using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveApple : MonoBehaviour
{
    [SerializeField] int moveSpeed;
    [SerializeField] int moveSpeed110;
    [SerializeField] int moveSpeed300;
      AudioSource hitSound;


     void Start()
    {
        hitSound = GetComponent<AudioSource>();    
    }

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
        if (collision.gameObject.CompareTag("Player"))
        {
            hitSound.Play();
        }
    }

  

    private void MoveObstacles()
    {
        if (!GameManager.instance.GameOver && GameManager.instance.Score < 200)
        {
            transform.position += Vector3.left * moveSpeed * Time.deltaTime;
        }

        if (!GameManager.instance.GameOver && GameManager.instance.Score > 200)
        {
            transform.position += Vector3.left * moveSpeed110 * Time.deltaTime;
        }

        if (!GameManager.instance.GameOver && GameManager.instance.Score > 400)
        {
            transform.position += Vector3.left * moveSpeed300 * Time.deltaTime;
        }
    }
}
