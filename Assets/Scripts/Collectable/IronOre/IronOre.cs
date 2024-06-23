using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IronOre : MonoBehaviour
{
    public float IronOreSpeedY;
    public Sprite sprite;

    void Start()
    {
        IronOreSpeedY = 5f;
    }

    void Update()
    {
        IronOreMovement();   
    }
    public void IronOreMovement()
    {
        transform.position += new Vector3(0, IronOreSpeedY * Time.deltaTime * -1, 0);
    }
}
