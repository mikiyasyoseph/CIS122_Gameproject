using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Transform[] spawners;

    [SerializeField] private GameObject enemy;

    private void Update()
    {
        if( Input.GetKeyDown(KeyCode.H))
        {
            SpawnEnemy();
        }
    }


    private void SpawnEnemy()
    {
        int randomInt = Random.Range(0, spawners.Length);
        Transform randomSpawner = spawners[randomInt];
        Instantiate(enemy, randomSpawner.position, randomSpawner.rotation);
    }
}


