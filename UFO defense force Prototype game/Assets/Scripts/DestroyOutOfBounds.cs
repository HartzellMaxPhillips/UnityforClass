using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float topBounds = 30f;
    
    public float lowerBounds = -12f;
    // Start is called before the first frame update
    void Awake()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > topBounds) 
        {
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBounds)
        {
            if(gameObject.name == "Powerup")
            {
                Destroy(gameObject);    
            }
            else
            {
            Debug.Log("Game Over.");
            Destroy(gameObject);
            //Time.timeScale = 0;
            }
        }
    }
}
