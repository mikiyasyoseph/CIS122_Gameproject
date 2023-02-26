//written by Mikiyas
// 2/26/23
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //variables/refrence
    [SerializeField] private Transform[] spawners;

    [SerializeField] private GameObject enemy;

    private void Update()
    {
        //checks if H is pressed and calls spawn enemy method
        if( Input.GetKeyDown(KeyCode.H))
        {
            SpawnEnemy();
        }
    }

    //spawns enemy picking from random spawners
    private void SpawnEnemy()
    {
        //generate random int
        int randomInt = Random.Range(0, spawners.Length);
        //pick random spawner using generated int 
        Transform randomSpawner = spawners[randomInt];
        //instantiate enemy at picked spawn point
        Instantiate(enemy, randomSpawner.position, randomSpawner.rotation);
    }
}


