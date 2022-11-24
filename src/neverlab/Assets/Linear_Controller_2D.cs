//=========== Written by Arthur W. Sheldon AKA Lizband_UCC ====================

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
	    // Invert horizontal axis
	    if (invertHorizontalAxis) movement.x *= -1;
	    
	    // Invert vertical axis
	    if (invertVerticalAxis) movement.y *= -1;

	    // Update object position
	    transform.Translate(movement * Time.deltaTime);
    }
    
    //=-----------------=
    // Internal Functions
    //=-----------------=
    private void UserInput()
    {
	    // Horizontal
	    if (Input.GetButton("MoveLeft")) movement.x = -moveSpeed;
	    else if (Input.GetButton("MoveRight")) movement.x = moveSpeed;
	    else movement.x = 0;
	    
	    // Vertical
	    if (Input.GetButton("MoveUp")) movement.y = moveSpeed;
	    else if (Input.GetButton("MoveDown")) movement.y = -moveSpeed;
	    else movement.y = 0;
    }


    //=-----------------=
    // External Functions
    //=-----------------=
}
