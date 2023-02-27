//written by Mikiyas
// 2/26/23
using System.Collections;
using System.Collections.Generic;
using System.Resources;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public enum SpawnState { SPAWNING, WAITING, COUNTING};
    //variables
    [SerializeField] private Wave[] waves;

    [SerializeField] private float timeBetweenWaves = 4f;
    [SerializeField] private float waveCountDown = 0;
    
    private SpawnState state = SpawnState.COUNTING;

    private int currentWave;


    //refrence
    [SerializeField] private Transform[] spawners;

    //[SerializeField] private GameObject enemy;


    private void Start()
    {
        //variables to track wave time
        waveCountDown = timeBetweenWaves;
        currentWave = 0;
    }
    private void Update()
    {
        //checks if H is pressed and calls spawn enemy method
        //if( Input.GetKeyDown(KeyCode.H))
        //{
        //    SpawnEnemy();
        //}

        //if wave countdown is less than 0
        if(state == SpawnState.WAITING)
        {
            //temporary fix for enemys spawning continously even though the amaount of enemies of the first wave should only be 5
            while(true)
            {
                //will be replaced by an if statment that checks if enemy are alive
                //and return empty so the next wave doesnt start 

                //else move to the next wave
                return;
            }
        }
        if(waveCountDown <= 0)
        {
            // if state is not equal to spawning it will move to the next wave
            if(state != SpawnState.SPAWNING)
            {
                StartCoroutine(SpawnWave(waves[currentWave]));
            }
        }else
        {
            //else it will countdown
            waveCountDown -= Time.deltaTime; 
        }
    }

    //This coroutine spawns a wave of enemies
    private IEnumerator SpawnWave(Wave wave)
    {
        //sets spawn state to spawning
        state = SpawnState.SPAWNING;

        //Spawn the number of enemies specified in the wave
        for (int x = 0; x < wave.enemiesAmount; x++)
        {
            SpawnEnemy(wave.enemy);
            yield return new WaitForSeconds(wave.delay);
        }
        
        //sets spawn state to waiting
        state = SpawnState.WAITING;

        //ends coroutine
        yield break;
    }

    //spawns enemy picking from random spawners
    private void SpawnEnemy(GameObject enemy)
    {
        //generate random int
        int randomInt = Random.Range(0, spawners.Length);
        //pick random spawner using generated int 
        Transform randomSpawner = spawners[randomInt];
        //instantiate enemy at picked spawn point
        Instantiate(enemy, randomSpawner.position, randomSpawner.rotation);
    }
}


