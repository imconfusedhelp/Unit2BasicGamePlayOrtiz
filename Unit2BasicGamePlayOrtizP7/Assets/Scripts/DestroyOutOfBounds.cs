using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // variable for topBound based on Z axis
    private float topBound = 30;

    // variable for lowerBound based on Z axis
    private float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // detect if object goes out of bounds
        if (transform.position.z > topBound)
        {
            // destroy object
            Destroy(gameObject);
        }
        else if (transform.position.z < lowerBound)
        {
            // display "Game Over!" in log when animal exits the lowerBound
            Debug.Log("Game Over!");

            // destroy object
            Destroy(gameObject);
        }
    }
}
