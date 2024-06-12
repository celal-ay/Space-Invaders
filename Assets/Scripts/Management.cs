using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Management : MonoBehaviour
{

    public GameObject Insects;
    public GameObject Asteroids;

    public int NumberOfInsects = 5; // Number of Insects in first wave;

    public float InsectSpawnLocationX; // Location of Insects that will be spawned.

    public int InsectCounter = 0; // Counter variables for feed the flag value.


    public bool SpawnerFlag = false; // Flag value for stopping InvokeRepeating function.



    void Start()
    {
        InvokeRepeating("SpawnInsects",2f, 0.4f); // Repeat process
        InvokeRepeating("SpawnAsteroids", 1f, 1.2f);
    }

    // Update is called once per frame
    void Update()
    {
        InsectSpawnLocationX = Random.Range(-60, 60); // Location Randomizer

        if(SpawnerFlag == true) // Iteration stopper. 
        {
            CancelInvoke("SpawnInsects");
        }
    }

    public void SpawnInsects() // Spawns Insects.
    {
        Instantiate(Insects, new Vector3(InsectSpawnLocationX, 75f, 67f), Insects.transform.rotation);


        InsectCounter++; // Counter value iteration.

        if(InsectCounter >= NumberOfInsects) // Condition that will stop the iteration of insect spawn.
        {
            SpawnerFlag = true; 
        }
    }
    public void SpawnAsteroids() // Spawns Asteroids.
    {
        Instantiate(Asteroids, new Vector3(InsectSpawnLocationX, 90f, 69f), Asteroids.transform.rotation); 
    }
}


