// Written by Hemron
// Sat Mar 11 2023

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSway : MonoBehaviour 
{

    [Header("Sway Settings")]
    [SerializeField] private float speed;
    [SerializeField] private float sensitivityMultiplier;

    private Quaternion refRotation;

    private float xRotation;
    private float yRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        // get mouse input
        float mouseX = Input.GetAxisRaw("Mouse X") * sensitivityMultiplier;
        float mouseY = Input.GetAxisRaw("Mouse Y") * sensitivityMultiplier;

        // calculate target rotation
		Quaternion rotationX = Quaternion.AngleAxis(-mouseY, Vector3.right);
		Quaternion rotationY = Quaternion.AngleAxis(mouseX, Vector3.up);

		Quaternion targetRotation = rotationX * rotationY;

        // rotate
        transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, speed * Time.deltaTime);
    }
}