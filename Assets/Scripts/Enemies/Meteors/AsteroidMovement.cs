using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.Experimental.AI;

public class AsteroidMovement : MonoBehaviour
{

    public float AsteroidSpeedY = 5f;

    public float RotationX = 0;
    public float RotationY = 0;
    public float RotationZ = 0;

    public float RandomX = 0;
    public float RandomY = 0;
    public float RandomZ = 0;

    void Start()
    {

        AsteroidSpeedY = 18;

        RotationX = 0.3f;
        RotationY = 0.3f;
        RotationZ = 0.3f;

        InvokeRepeating("AsteroidRotationRandomizer", 0.2f, 2f);

    }

    void Update()
    {
        transform.position += new Vector3(0, AsteroidSpeedY * Time.deltaTime * -1, 0);

        transform.Rotate(RotationX * RandomX, RotationY * RandomY, RotationZ * RandomZ); // Rotation configuration.

        if(transform.position.y <= -10)
        {
            Destroy(gameObject);
        }

    }

    public void AsteroidRotationRandomizer() // Rotation Randomizer.
    {
        RandomX = Random.Range(-1, 1);
        RandomY = Random.Range(-1, 1);
        RandomZ = Random.Range(-1, 1);
    }

}   
