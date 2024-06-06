using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Android;

public class Shooting : MonoBehaviour
{
    public GameObject missile;
    public Vector3 missileSpawnPositon;   // ASSIGMENT OF MISSILES' LOCATION  

    public int shootRate = 0; // SHOOT RATE OF THE GUN


    void Start()
    {
    }

    void Update()
    {
        MissileTrigger(); // SPAWNER OF THE MISSILE TO THE GIVEN LOCATION
        missileSpawnPositon = transform.position;
        missileSpawnPositon.z = transform.position.z + 3;
    }

    public void MissileTrigger()
    {
        if(Input.GetKeyDown(KeyCode.Space)) 
        {
                Instantiate(missile, missileSpawnPositon, transform.rotation);
        }
    }
}

