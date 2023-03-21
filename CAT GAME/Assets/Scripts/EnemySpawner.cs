using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public Transform[] SpawnPoints;

    public GameObject Block;

    private float TimeToSpawn = 3f;
    public float TimeBetweenWaves = 2f;

    private void Update()
    {
        if (Time.time >= TimeToSpawn)
        {
            SpawnBlocks();
            TimeToSpawn = Time.time + TimeBetweenWaves;

        }

    }


    void SpawnBlocks()
    {
        int RandomIndex = Random.Range(0, SpawnPoints.Length);

        for (int i = 0; i < SpawnPoints.Length; i++)
        {
            if (RandomIndex != i)
            {
                Instantiate(Block, SpawnPoints[i].position, Quaternion.identity);
            }

        }
    }


}
