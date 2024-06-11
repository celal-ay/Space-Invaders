using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMechanic : MonoBehaviour
{
    public float missile_speed = 5;
    private void Update()
    {
        transform.Translate(Vector3.forward * missile_speed / 15);  // THIS DESTROYS THE MISSILE IF IT EXCEEDS THE DISTANCE LIMIT
        if(transform.position.y >= 90)                              // IMPORTANT FOR OPTIMIZATION
        {
            Destroy(gameObject);
        }
    }

    // Collision detect (If missile hits the insect, both of them will be destroyed
    // This mechanic can be improved (I will deal it with later)
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("FlyingInsect")) // I will recognize the collision object with TAG system in Unity.
        {
            Destroy(gameObject); // THIS REPRESENTS THE MISSILE (the game object that containing this script).
            Destroy(collision.gameObject); // THIS REPRESENT THE INSECT (the game object whose collider you are colliding with.
        }
    }
}
