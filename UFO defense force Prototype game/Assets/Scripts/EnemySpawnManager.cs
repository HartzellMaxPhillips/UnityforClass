using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnManager : MonoBehaviour
{
    public GameObject[] ufoPrefabs; //Array to store UFO ships
    private float spawnRangeX = 14f;

    private float spawnPosZ = 18f;
    
    private float startDelay = 2f;
    private float spawnInterval = 1f;
    void Start() 
    {
        InvokeRepeating("SpawnRandomUFO", startDelay, spawnInterval);
    }
    // Update is called once per frame

    void SpawnRandomUFO() 
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1, spawnPosZ);
        int ufoIndex = Random.Range(0, ufoPrefabs.Length); //Picks a random UFO from the array
        Instantiate(ufoPrefabs[ufoIndex], spawnPos, ufoPrefabs[ufoIndex].transform.rotation); //Spawns a Indexed UFO at a random location on the X Axis.
    }
}
