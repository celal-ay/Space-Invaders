using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Android;

public class Shooting : MonoBehaviour
{
    public GameObject missile;
    public Vector3 missileSpawnPositon;   // ASSIGMENT OF MISSILES' LOCATION  

    public int NumberOfMissiles = 0;
    public bool MissileActive = false;


    void Start()
    {
        NumberOfMissiles = 10; // Base number of missiles.
        MissileActive = true;
    }

    void Update()
    {
        MissileTrigger(); // SPAWNER OF THE MISSILE TO THE GIVEN LOCATION
        missileSpawnPositon = transform.position;
        missileSpawnPositon.z = transform.position.z + 3;
    }

    public void MissileTrigger()
    {
        if(Input.GetKeyDown(KeyCode.Space) && MissileActive == true) 
        {
                Instantiate(missile, missileSpawnPositon, transform.rotation);
                NumberOfMissiles--;
        }
        if(NumberOfMissiles == 0)
        {
            MissileActive = false;
        }
    }
}

// TODO: CEPHANELÝÐÝ ARTIRACAK BOOSTLAR VESAÝRE GELÝÞTÝR
// YENÝ BÝR SAHNE YAP. ENVANTERÝ FALAN GÖZLEMLEYEBÝLECEÐÝN


