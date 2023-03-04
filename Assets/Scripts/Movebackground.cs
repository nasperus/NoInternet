using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movebackground : MonoBehaviour
{
    [SerializeField] float xOffset;
    Material material;
    void Start()
    {
        material = GetComponent<Renderer>().material;
    }

   
    void Update()
    {
        if (!GameManager.instance.gameOver)
        {
            GameManager.instance.IncreaseScore();
            Vector2 offset = new Vector2(xOffset, 0);
            material.mainTextureOffset += offset * Time.deltaTime;
        }
      
    }
}
