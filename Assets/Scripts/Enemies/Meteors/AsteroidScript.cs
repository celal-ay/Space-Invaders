using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidScript : MonoBehaviour
{


    public int health = 0;
    public float randomNumber;
    public GameObject IronOre;


    void Start()
    {
        health = 3;
    }

    void Update()
    {
        Randomizer();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Missile")) // If missile hits the asteroid, the health of asteroid will be decreased.
        {
            health--;
            Destroy(collision.gameObject);

            if (health == 0)
            {
                Destroy(collision.gameObject);
                if(randomNumber > 50) // 50% chance of drop an item.
                {
                    Debug.Log("Dropped an item"); // I will use an Instantiate method but not now.
                    Instantiate(IronOre, transform.position, transform.rotation);
                }
                Destroy(gameObject);
            }
        }
    }

    public void Randomizer()
    {
        randomNumber = Random.Range(0, 100);
    }
}
