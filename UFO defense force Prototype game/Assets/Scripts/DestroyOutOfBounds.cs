using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameManager GameManager;
    public float topBounds = 30f;
    public float lowerBounds = -12f;

    public GameObject PowerUpObject;
    
    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds) 
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBounds)
        {
            if(gameObject.name == "Powerup(Clone)")
            {
                Destroy(gameObject);    
            }
            else
            {
                Debug.Log("originalGO");
                GameManager.isGameOver = true; 
                Destroy(gameObject);
                Time.timeScale = 0;
            }
        }
    }
}
