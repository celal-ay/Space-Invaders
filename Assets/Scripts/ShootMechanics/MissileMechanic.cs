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
}
