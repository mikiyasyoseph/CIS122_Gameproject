// written by Hermon Metaferia
// Sat Feb 25 2023

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    // creating new variables
    [SerializeField] Movement movement;

    PlayerControls controls;
    PlayerControls.GroundMovementActions groundMovement;

    Vector2 horizontalInput;

    // methods
    private void Awake()
    {
        controls = new PlayerControls();
        groundMovement = controls.GroundMovement;
        // groundMovement.[action].performed += context => do something
        groundMovement.HorizontalMovement.performed += context => horizontalInput = context.ReadValue<Vector2>();
    }
    
    private void OnEnable() 
    {
        controls.Enable();
    }

    private void OnDestroy() 
    {
        controls.Disable();
    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.ReceiveInput(horizontalInput);
    }
}
