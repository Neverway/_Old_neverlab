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
    [SerializeField] private float speed;
    [SerializeField] private bool invertHorizontalAxis;
    [SerializeField] private bool invertVerticalAxis;


    //=-----------------=
    // Private Variables
    //=-----------------=
    private Vector2 velocity;
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
	    if (invertHorizontalAxis) velocity.x *= -1;
	    
	    // Invert vertical axis
	    if (invertVerticalAxis) velocity.y *= -1;

	    // Update object position
	    transform.Translate(velocity * Time.deltaTime);
    }
    
    //=-----------------=
    // Internal Functions
    //=-----------------=
    private void UserInput()
    {
	    // Horizontal
	    if (Input.GetButton("MoveLeft")) velocity.x = -speed;
	    else if (Input.GetButton("MoveRight")) velocity.x = speed;
	    else velocity.x = 0;
	    
	    // Vertical
	    if (Input.GetButton("MoveUp")) velocity.y = speed;
	    else if (Input.GetButton("MoveDown")) velocity.y = -speed;
	    else velocity.y = 0;
    }


    //=-----------------=
    // External Functions
    //=-----------------=
}
