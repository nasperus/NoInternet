using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    [SerializeField] GameObject obstacle;
    public int minPos, maxPos;
    void Start()
    {
        InvokeRepeating(nameof(Spawning),1,1.5f);
    }

    
    void Update()
    {
        
    }

    private void Spawning()
    {
        int randomPos = Random.Range(minPos, maxPos);
        Vector3 pos = new Vector3(randomPos, transform.position.y, transform.position.z);
        Instantiate(obstacle, pos, transform.rotation);
    }
}
