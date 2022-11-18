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
    private Vector3 movement;
    
    
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
    }
    
    //=-----------------=
    // Internal Functions
    //=-----------------=
    private void UserInput()
    {
	    // Horizontal
	    if (Input.GetButton("MoveLeft"))
	    {
		    movement.x = invertHorizontalAxis switch
		    {
			    (true) => 1,
			    (false) => -1
		    };
	    }
	    else if (Input.GetButton("MoveRight"))
	    {
		    movement.x = invertHorizontalAxis switch
		    {
			    (true) => -1,
			    (false) => 1
		    };
	    }
	    else
	    {
		    movement.x = 0;
	    }
	    
	    // Vertical
	    if (Input.GetButton("MoveUp"))
	    {
		    movement.y = invertVerticalAxis switch
		    {
			    (true) => -1,
			    (false) => 1
		    };
	    }
	    else if (Input.GetButton("MoveDown"))
	    {
		    movement.y = invertVerticalAxis switch
		    {
			    (true) => 1,
			    (false) => -1
		    };
	    }
	    else
	    {
		    movement.y = 0;
	    }
    }


    //=-----------------=
    // External Functions
    //=-----------------=
}


