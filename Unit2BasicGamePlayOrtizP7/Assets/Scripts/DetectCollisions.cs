using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
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
        
    }

    // "when trigger is entered..."
    private void OnTriggerEnter(Collider other)
    {
        // if animal collides with player
        if (other.CompareTag("Player"))
        {
            gameManager.AddLives(-1);

            // destroy projectile
            Destroy(gameObject);
        }
        if(other.CompareTag("Animal"))
        {
            other.GetComponent<AnimalHunger>().FeedAnimal(1);
            Destroy(gameObject);
        }

    }
}
