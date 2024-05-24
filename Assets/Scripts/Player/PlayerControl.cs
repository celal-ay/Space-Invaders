using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline;
using UnityEngine;


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
        MovementSpeedX = 115f;

        MovementSpeedY = 55f;

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
        transform.Translate(Vector3.right * MovementSpeedX * HorizontalInput * Time.deltaTime);

        transform.Translate(Vector3.forward * MovementSpeedY * VerticalInput * Time.deltaTime);

        //transform.Rotate(Vector3.back * 30 * HorizontalInput);
    }
}
