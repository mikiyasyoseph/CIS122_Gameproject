// written by Hermon Metaferia
// Sat Feb 25 2023

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    // create a variable
    [SerializeField] CharacterController controller;
    [SerializeField] float speed = 11f;

    Vector2 horizontalInput;
    
    //the gravity should be -9.8 but for a snapier result we used -30
    [SerializeField] float gravity = - 30f; 
    Vector3 verticalVelocity = Vector3.zero;

    [SerializeField] LayerMask groundMask;
    bool isGrounded;


    //methods
    public void ReceiveInput (Vector2 aHorizontalInput) 
    {
        horizontalInput = aHorizontalInput;
        print(horizontalInput);

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGrounded = Physics.CheckSphere(transform.position, 0.1f , groundMask);

        if(isGrounded == true)
        {
            verticalVelocity.y = 0;
        }

        Vector3 horizontalVelocity = (transform.right * horizontalInput.x
                                     + transform.forward *horizontalInput.y) * speed;
        controller.Move(horizontalVelocity * Time.deltaTime);

        verticalVelocity.y += gravity  *  Time.deltaTime;
        controller.Move(verticalVelocity * Time.deltaTime);

    }
}
