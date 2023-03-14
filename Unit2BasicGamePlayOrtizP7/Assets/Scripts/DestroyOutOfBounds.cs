using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    // variable for topBound based on Z axis
    private float topBound = 30;

    // variable for lowerBound based on Z axis
    private float lowerBound = -10;

    // variable for sideBound based on X axis
    private float sideBound = 30;

    // variable for GameManager script
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
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
            // remove a life 
            gameManager.AddLives(-1);

            // destroy object
            Destroy(gameObject);
        }
        else if (transform.position.x > sideBound)
        {
            gameManager.AddLives(-1);

            // destroy object
            Destroy(gameObject);
        }
        else if (transform.position.x < -sideBound)
        {
            gameManager.AddLives(-1);

            // destroy object
            Destroy(gameObject);
        }
    }
}
