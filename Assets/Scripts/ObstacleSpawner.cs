using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] obstacles;
    [SerializeField] private float spawnRate;
    private Vector3 spawnPos;

    // Start is called before the first frame update
    void Start()
    {
        spawnPos = transform.position;

        StartCoroutine(SpawnObstacles());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnObstacles()
    {
        while (true)
        {
            Spawn();

            yield return new WaitForSeconds(spawnRate);
        }
    }

    private void Spawn()
    {
        int randObstacle = Random.Range(0, obstacles.Length);

        Instantiate(obstacles[randObstacle], spawnPos, transform.rotation);
    }
}
