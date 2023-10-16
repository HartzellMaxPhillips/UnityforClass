using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 25;

    public float xRange = 30;

    public Transform blaster;
    public GameObject laserBolt;

    public int powerUpCount = 0;
   

    // Update is called once per frame
    void Update()
    {
        //Get's input of horizontal keys (left/right and 'a' and 'd')
        horizontalInput = Input.GetAxis("Horizontal");

        //Moves player left and right.
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        //keeping the player in bounds
        //Left side
        if(transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        //Right side
        if(transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        //if spacebar is pressed, fire laserbolt
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Create the laserBolt at the blasters position, maintaining the Objects Rotation.
            Instantiate(laserBolt, blaster.transform.position, laserBolt.transform.rotation);
        }

        
    }

    private void OnTriggerEnter(Collider other) 
    {


        if(other.CompareTag("Powerup")) 
        {
            powerUpCount++;
            Debug.Log(powerUpCount);
            Destroy(other.gameObject);  
        }
    }
}
