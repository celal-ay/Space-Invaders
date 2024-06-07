using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Management : MonoBehaviour
{

    public GameObject Insects;

    public int NumberOfInsects = 5; // Number of Insects in first wave;

    public float InsectSpawnLocationX; // Location of Insects that will be spawned

    public int InsectCounter = 0; // Flag value for stopping InvokeRepeating function



    void Start()
    {
        InvokeRepeating("SpawnInsects",2f, 0.4f); // Repeat process
    }

    // Update is called once per frame
    void Update()
    {
        InsectSpawnLocationX = Random.Range(-60, 60); // Location Randomizer
    }

    public void SpawnInsects() // Spawns Insects
    {
            Instantiate(Insects, new Vector3(InsectSpawnLocationX, 75f, 67f), Insects.transform.rotation);
    }
}

// TODO: SOLVE THE BUGS

