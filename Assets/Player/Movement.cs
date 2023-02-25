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
        Vector3 horizontalVelocity = (transform.right * horizontalInput.x
                                     + transform.forward *horizontalInput.y) * speed;
        controller.Move(horizontalVelocity * Time.deltaTime);
    }
}
