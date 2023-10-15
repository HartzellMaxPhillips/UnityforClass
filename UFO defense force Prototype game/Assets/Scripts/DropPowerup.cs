using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropPowerup : MonoBehaviour
{
    public Transform powerupSpawner;
    public GameObject powerup;
    // Start is called before the first frame update
    void Start()
    {
        
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
}
