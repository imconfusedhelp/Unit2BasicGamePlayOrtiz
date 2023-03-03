using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;

    private float spawnRangeX = 12f;
    private float spawnPosZ = 20f;
    private float startDelay = 1f;
    private float spawnInterval = 0.7f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    // function which holds spawning rules
    void SpawnRandomAnimal()
    {
        // randomly generate animal type and spawn location
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);

        // locally declare animal index for various animal types
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // instatiate the animals
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
