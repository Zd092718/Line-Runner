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

            GameManager.instance.UpdateScore();
            yield return new WaitForSeconds(spawnRate);
        }
    }

    private void Spawn()
    {
        int randObstacle = Random.Range(0, obstacles.Length);

        int randomSpot = Random.Range(0, 2); // 0 = top, 1 = bottom

        if (randomSpot < 1)
        {
            //spawn at top
            Instantiate(obstacles[randObstacle], spawnPos, transform.rotation);
        }
        else
        {
            //spawn at bottom
            Vector3 botSpawnPos = new Vector3(spawnPos.x, -spawnPos.y, spawnPos.z);
            Instantiate(obstacles[randObstacle], botSpawnPos, transform.rotation);
        }


    }
}
