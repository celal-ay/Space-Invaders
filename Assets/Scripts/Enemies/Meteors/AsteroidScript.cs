using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{


    public int health = 0; 

    void Start()
    {
        health = 3;
    }

    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Missile")) // If missile hits the asteroid, the health of asteroid will be decreased.
        {
            health--;

            if(health == 0)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
        }
    }
}
