using System.Collections;
using System.Collections.Generic;
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

    Vector3 PlayerPosition;


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

        //transform.Translate(Vector3.right * MovementSpeedX * HorizontalInput * Time.deltaTime);
        //transform.Translate(Vector3.forward * MovementSpeedY * VerticalInput * Time.deltaTime);

        transform.position += new Vector3(HorizontalInput * Time.deltaTime * MovementSpeedX, VerticalInput * Time.deltaTime * MovementSpeedY, 0);

        if (HorizontalInput != 0)
        {
            if(transform.rotation.y < 0.15f && HorizontalInput < 0)
            {
                transform.Rotate(0, 0, -HorizontalInput * MovementSpeedX / 100);
            }
            if(transform.rotation.y > -0.15f && HorizontalInput > 0)
            {
                transform.Rotate(0, 0, -HorizontalInput * MovementSpeedX / 100);
            }
            //transform.Rotate(0, 0, -HorizontalInput * Time.deltaTime * MovementSpeedX);
            Debug.Log(transform.rotation.y); // 0.15 olana kadar çevir

        }
    }
}