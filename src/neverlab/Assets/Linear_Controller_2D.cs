//=========== Written by Arthur W. Sheldon AKA Lizband_UCC ====================
// 
// Purpose:
//			Move a game object using keycode inputs
// Applied to: 
//			The root of the controllable game object
// Notes: 
//
//=============================================================================

using UnityEngine;

public class Linear_Controller_2D : MonoBehaviour
{
    //=-----------------=
    // Public Variables
    //=-----------------=
    [Tooltip("Multiplier for how fast the object will move")]
    [SerializeField] private float moveSpeed;


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
	    if (Input.GetKey(KeyCode.LeftArrow))
	    {
		    movement.x = -1;
	    }
	    else if (Input.GetKey(KeyCode.RightArrow))
	    {
		    movement.x = 1;
	    }
	    else
	    {
		    movement.x = 0;
	    }
    }


    //=-----------------=
    // External Functions
    //=-----------------=
}

