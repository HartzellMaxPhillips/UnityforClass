using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider Other) 
    {
        if (Other.CompareTag("Player ship"))
        {

        }
        else 
        {
            Destroy(gameObject);
            Destroy(Other.gameObject);
        }
    }

}
