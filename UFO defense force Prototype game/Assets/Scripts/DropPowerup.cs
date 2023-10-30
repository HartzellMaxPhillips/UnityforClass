using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPowerup : MonoBehaviour
{
    public Transform powerupSpawner;
    public GameObject powerup;

    private float spawnRangeX = 14f;

    private float spawnPosZ = 20f;

    private float startDelay = 4f;

    private float spawnInterval = 5f;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPowerup", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        //Press P to release a powerup, will find a different method to drop a powerup later.
        if(Input.GetKeyDown(KeyCode.P)) 
        {
            Instantiate(powerup, powerupSpawner.transform.position, powerup.transform.rotation);
        }
    }

        void SpawnPowerup() 
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1, spawnPosZ);
        Instantiate(powerup, spawnPos, powerup.transform.rotation); //Spawns a powerup
    }
}
