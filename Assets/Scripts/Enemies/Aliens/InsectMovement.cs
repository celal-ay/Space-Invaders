using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsectMovement : MonoBehaviour
{

    public int randomValue; // This feeds the direction condition.
    public int InsectSpeedX;

    void Start()
    {
        InvokeRepeating("Randomizer", 0.7f, 3f); // It randoms a value and stores for 3 seconds
        InsectSpeedX = 5;
    }

    void Update()
    {
        if (randomValue <= 0) // Object's movement direction coming from this. (Direction feeding by random value).
        {
            transform.Translate(InsectSpeedX * Time.deltaTime, 0, 0);
        }
        else if (randomValue > 0)
        {
            transform.Translate(InsectSpeedX * Time.deltaTime * -1, 0, 0);
        }
    }
    public void Randomizer()
    {
        randomValue = Random.Range(-1, 3); // If Random.Range() is int, the minium value is inclusive and maximum value is exclusive.
                                           // This func returns -1, 0, 1, 2
    }
}

// TODO: Adjustments of speeds, add wall behaviour
// NOT IN THIS SCRIPT BUT ADD COLLISION DETECTS TO THE INSECTS.

