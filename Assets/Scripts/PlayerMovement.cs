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
        // ******** CUBES ********//

        // Variable to assign the GO
        GameObject[] cube;
        // Find the GO with the Tags Cubes
        cube = GameObject.FindGameObjectsWithTag("Cubes");

        // If the tag is distinct from null then we enter to the changing light condition
        if (cube != null && other.gameObject.tag == "Cubes")
        {
            // Message in the console to know we enter in the event
            Debug.Log("Cube has been found");
            
            // Find the Light GO
            Light light = GameObject.FindObjectOfType<Light>();
            // If the GO light is found 
            if(light != null)
            {
                // Then the color is changed to red
                light.color = Color.red; 
            }                               
        }

        // ******** SPHERES ********//

        // Variable to assign the GO
        GameObject[] sphere;

        // Find the GO with the Tags spheres
        sphere = GameObject.FindGameObjectsWithTag("Spheres");

        // If the tag is distinct from null then we enter to the changing light condition
        if (sphere != null && other.gameObject.tag == "Spheres")
        {
            // Message in the console to know we enter in the event
            Debug.Log("Sphere has been found");

            // Find the Light GO
            Light light = GameObject.FindObjectOfType<Light>();
            // If the GO light is found 
            if (light != null)
            {
                // Then the color is changed to red
                light.color = Color.blue;
            }
        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        // Find the Light GO
        Light light = GameObject.FindObjectOfType<Light>();
        // If the GO light is found 
        if (light != null)
        {
            // Then the color is changed to white
            light.color = Color.white;
        }
    }
}
