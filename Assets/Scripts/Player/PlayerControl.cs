using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Timeline;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;


public class PlayerControl : MonoBehaviour
{
    public GameObject Player; //Attachment variable 
    public Rigidbody RB; // For the physical purposes like movement, collision etc...
    public InventoryManager inventoryManager;

    public Sprite itemSpriteOre;

    public int CollectedIronOre;

    float VerticalInput;
    float HorizontalInput;

    public float MovementSpeedX;
    public float MovementSpeedY;


    void Start()
    {

        MovementSpeedX = 90f;

        MovementSpeedY = 35f;

        RB = GetComponent<Rigidbody>(); // IT IS NOT NECESSARY FOR NOW
        inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();

        CollectedIronOre = 0;



    }

    void Update()
    {
        MyInput();
        PlayerMovement();
    }

    public void MyInput()
    {
        VerticalInput = Input.GetAxis("Vertical");
        HorizontalInput = Input.GetAxis("Horizontal");
    }
    public void PlayerMovement()
    {

        transform.position += new Vector3(HorizontalInput * Time.deltaTime * MovementSpeedX, VerticalInput * Time.deltaTime * MovementSpeedY, 0); // transfomr.Translate kullanmadým çünkü ihtiyacýmý karþýlamýyordu.


        if(transform.position.x < -80) //Wall behaviour for left side
        {
            transform.position = new Vector3(-80, transform.position.y, transform.position.z);
        }
        if(transform.position.x > 80) // Wall behaviour for right side
        {
            transform.position = new Vector3(80, transform.position.y, transform.position.z);
        }


        if (HorizontalInput != 0)
        {
            if (transform.rotation.y < 0.15f && HorizontalInput < 0) // It is about rotation.
            {
                transform.Rotate(0, 0, -HorizontalInput * MovementSpeedX / 50);
            }
            if (transform.rotation.y > -0.15f && HorizontalInput > 0)
            {
                transform.Rotate(0, 0, -HorizontalInput * MovementSpeedX / 50);
            }
        }
        if (Input.anyKey == false && transform.rotation.y < 0) // I used transform.rotation.y value for flagging. 
        {
            transform.Rotate(0, 0, 1);
        }
        if(Input.anyKey == false && transform.rotation.y > 0) // I TRIED VERY DIFFERENT THINGS BUT ONLY THIS WORKS
        {
            transform.Rotate(0, 0, -1);
        }
    }


    private void OnCollisionEnter(Collision collision)  // This method collecting materials.
    {
        if (collision.collider.gameObject.CompareTag("IronOre"))
        {
            
            Destroy(collision.gameObject);
            CollectedIronOre++;
            Debug.Log(CollectedIronOre);
            inventoryManager.AddItem(collision.gameObject.name, CollectedIronOre, itemSpriteOre);
            
           
        }
    }
}



// Debug.Log() ve Unity konsolundan yardým alarak bazý deðerleri flag value olarak kullanmayý öðrendin.
