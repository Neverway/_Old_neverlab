//=========== Written by Arthur W. Sheldon AKA Lizband_UCC ====================
// 
// Purpose: 
// Applied to: 
// Notes: 
//
//=============================================================================

using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class Linear_Controller_2D : MonoBehaviour
{
    //=-----------------=
    // Public Variables
    //=-----------------=
    [SerializeField] private float moveSpeed;
    [SerializeField] private bool invertHorizontalAxis;
    [SerializeField] private bool invertVerticalAxis;


    //=-----------------=
    // Private Variables
    //=-----------------=
    private Vector2 movement;
    private int horizontalInversion;
    private int verticalInversion;
    
    
    //=-----------------=
    // Reference Variables
    //=-----------------=


    //=-----------------=
    // Mono Functions
    //=-----------------=
    private void Update()
    {
	    UserInput();
    }

    private void FixedUpdate()
    {
	    // Update object position
	    transform.Translate(movement * moveSpeed * Time.deltaTime);
	    
	    // Set horizontal inverted inputs
	    if (invertHorizontalAxis) horizontalInversion = -1;
	    else horizontalInversion = 1;
	    
	    // Set vertical inverted inputs
	    if (invertVerticalAxis) verticalInversion = -1;
	    else verticalInversion = 1;
    }
    
    //=-----------------=
    // Internal Functions
    //=-----------------=
    private void UserInput()
    {
	    // Horizontal
	    if (Input.GetButton("MoveLeft")) movement.x = -1 * horizontalInversion;
	    else if (Input.GetButton("MoveRight")) movement.x = 1 * horizontalInversion;
	    else movement.x = 0;
	    
	    // Vertical
	    if (Input.GetButton("MoveUp")) movement.y = 1 * verticalInversion;
	    else if (Input.GetButton("MoveDown")) movement.y = -1 * verticalInversion;
	    else movement.y = 0;
    }


    //=-----------------=
    // External Functions
    //=-----------------=
}


