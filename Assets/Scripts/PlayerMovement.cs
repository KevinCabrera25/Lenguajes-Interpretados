using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Variable to control the velocity of the movement
    private float velocity = 5f;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Movement in x direction
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(velocity, 0f, 0f) * Time.deltaTime);
        }
        // Movement in -x direction
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(-velocity, 0f, 0f) * Time.deltaTime);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject[] cube;
        cube = GameObject.FindGameObjectsWithTag("Cubes"); 
        if(cube != null)
        {
            Debug.Log("Cube has been found");

            /*
            Light light = GameObject.FindObjectOfType<Light>();
            if(light != null)
            {
                light.color = Color.red; 
            }
            */
                   
        }
    }

}
