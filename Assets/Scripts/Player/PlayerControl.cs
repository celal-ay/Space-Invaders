using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Timeline;
using UnityEngine;
using UnityEngine.UIElements;


public class PlayerControl : MonoBehaviour
{
    public GameObject Player; //Attachment variable 
    public Rigidbody RB; // For the physical purposes like movement, collision etc...

    float VerticalInput;
    float HorizontalInput;

    Vector3 MoveDirectionX;
    Vector3 MoveDirectionY;


    public float MovementSpeedX;
    public float MovementSpeedY;


    void Start()
    {
        MovementSpeedX = 90f;

        MovementSpeedY = 35f;

        RB = GetComponent<Rigidbody>();

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

        if (HorizontalInput != 0)
        {
            if (transform.rotation.y < 0.15f && HorizontalInput < 0)
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
        if(Input.anyKey == false && transform.rotation.y > 0) // kendinle gurur duyduðun bir mekanik.
        {
            transform.Rotate(0, 0, -1);
        }
    }
}



// Debug.Log() ve Unity konsolundan yardým alarak bazý deðerleri flag value olarak kullanmayý öðrendin.
