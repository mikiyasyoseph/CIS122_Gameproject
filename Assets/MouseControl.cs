//Name:
//Date:

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseControl : MonoBehaviour
{
    public float mouseSensetivity = 100f; //This is a default value for mouse sentivity

    public Transform playerBody; //This is a link up space for the player.

    float xRotation = 0f; //A default value for a counter rotation for the y-axis
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // The reason we do this is to hide and lock our cursor in place.
       
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensetivity * Time.deltaTime; //This is "formula" helps the player move in present time ans sensetivity to mouse along the x_axis
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensetivity * Time.deltaTime; //This is "formula" helps the player move in present time ans sensetivity to mouse along the y_axis

        xRotation -= mouseY;      //The reason we minus it is beacuse when plaus it is flipped upside down.
        xRotation = Mathf.Clamp(xRotation, -90f, 90f); //Used for clamping purposes. So the head doesn't flip all the way.

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); //Value responsible for rotation in unity "Quaternion".
        playerBody.Rotate(Vector3.up * mouseX); // For x axis rotation.





    }
}
