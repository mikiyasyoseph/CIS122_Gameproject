// Written by Hemron
// Sat Mar 11 2023

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
{  
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator> () ;
       // Debug. Log (animator) ;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey ("a"))
        {
            // then set the isRuning boole to true
            animator. SetBool("isMovingLeft ", true);
        }
        if (!Input.GetKey ("a"))
        {
            // then set the isRuning boole to true
            animator. SetBool("isMovingLeft", false);
        }
        
        if (Input.GetKey ("w"))
        {
            // then set the isRuning boole to true
            animator. SetBool("isRuningForward", true);
        }
        if (!Input.GetKey ("w"))
        {
            // then set the isRuning boole to true
            animator. SetBool("isRuningForward", false);
        }
        if (Input.GetKey ("s"))
        {
            // then set the isRuning boole to true
            animator. SetBool("isRuningBackward", true);
        }
        if (!Input.GetKey ("s"))
        {
            // then set the isRuning boole to true
            animator. SetBool("isRuningBackward", false);
        }
        if (Input.GetKey ("d"))
        {
            // then set the isRuning boole to true
            animator. SetBool("isStrafingRight", true);
        }
        if (!Input.GetKey ("d"))
        {
            // then set the isRuning boole to true
            animator. SetBool("isStrafingRight", false);
        }
        
        if (Input.GetKey (" "))
        {
            // then set the isRuning boole to true
            animator. SetBool("isJumping", true);
        }
        if (!Input.GetKey (" "))
        {
            // then set the isRuning boole to true
            animator. SetBool("isJumping", false);
        }
    }
}
