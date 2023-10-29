using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager; //reference to scoremanager
    public GameObject UFO_Scout;
    public GameObject UFO_Cruiser;
    public GameObject UFO_Mothership;

    public int scoreToGive;
    void Start() 
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>();
    }
    void OnTriggerEnter(Collider Other) 
    {
        if (Other.CompareTag("Bolt"))
        {
            scoreManager.IncreaseScore(scoreToGive);
            Destroy(gameObject);
            Destroy(Other.gameObject);
        }

        if (Other.CompareTag("UFO")) 
        {
        Physics.IgnoreCollision(UFO_Scout.GetComponent<Collider>(), UFO_Cruiser.GetComponent<Collider>(), true);
        Physics.IgnoreCollision(UFO_Scout.GetComponent<Collider>(), UFO_Mothership.GetComponent<Collider>(), true);
        Physics.IgnoreCollision(UFO_Mothership.GetComponent<Collider>(), UFO_Cruiser.GetComponent<Collider>(), true);
        Physics.IgnoreCollision(UFO_Mothership.GetComponent<Collider>(), UFO_Scout.GetComponent<Collider>(), true);
        Physics.IgnoreCollision(UFO_Cruiser.GetComponent<Collider>(), UFO_Scout.GetComponent<Collider>(), true);
        Physics.IgnoreCollision(UFO_Cruiser.GetComponent<Collider>(), UFO_Mothership.GetComponent<Collider>(), true);
        }
    }

}
