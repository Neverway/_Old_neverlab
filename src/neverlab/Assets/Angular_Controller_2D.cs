//========== Neverway 2022 Project Script | Written by Unknown Dev ============
// 
// Purpose: 
// Applied to: 
// Editor script: 
// Notes: 
//
//=============================================================================

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Angular_Controller_2D : MonoBehaviour
{
    //=-----------------=
    // Public Variables
    //=-----------------=
    public float speed;
    [SerializeField] private bool invertHorizontalAxis;


    //=-----------------=
    // Private Variables
    //=-----------------=
    private Vector3 velocity;
    
    
    //=-----------------=
    // Reference Variables
    //=-----------------=


    //=-----------------=
    // Mono Functions
    //=-----------------=
    private void Start()
    {
	
    }

    private void Update()
    {
	    UserInput();
    }

    private void FixedUpdate()
    {
	    // Invert horizontal axis
	    if (invertHorizontalAxis) velocity.z *= -1;

	    // Update object position
	    transform.Rotate(velocity * Time.deltaTime);
    }

    //=-----------------=
    // Internal Functions
    //=-----------------=
    private void UserInput()
    {
	    // Horizontal
	    if (Input.GetButton("TurnLeft")) velocity.z = speed;
	    else if (Input.GetButton("TurnRight")) velocity.z = -speed;
	    else velocity.z = 0;
    }
    
    
    //=-----------------=
    // External Functions
    //=-----------------=
}

