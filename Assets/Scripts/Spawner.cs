using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject spawnGameObject;
    [Range(1, 5)] public float minSpawnTime = 2;
    [Range(5, 10)] public float maxSpawnTime = 5;

    private float spawnTimer;

    // Start is called before the first frame update
    void Start()
    {
        spawnTimer = Random.Range(minSpawnTime, maxSpawnTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.childCount == 0)
        {
            spawnTimer -= Time.deltaTime;
        }
        
        if (spawnTimer <= 0)
        {
            spawnTimer = Random.Range(minSpawnTime, maxSpawnTime);
            Instantiate(spawnGameObject, transform.position, transform.rotation, transform);
        }
    }
}
