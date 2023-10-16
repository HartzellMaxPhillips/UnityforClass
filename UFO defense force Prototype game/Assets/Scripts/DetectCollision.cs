using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider Other) 
    {
        if (gameObject.name == "Player ship")
        {

        }
        else 
        {
            Destroy(gameObject);
            Destroy(Other.gameObject);
        }
    }

}
