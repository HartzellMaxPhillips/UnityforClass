using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCharacter : MonoBehaviour
{
    private Rigidbody characterController;

    public float Speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W))
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        
        if(Input.GetKey(KeyCode.D))
            transform.Translate(Vector3.forward * -Speed * Time.deltaTime);
    }
}
