//========== Neverway 2022 Project Script | Written by Unknown Dev ============

using UnityEngine;

public class Angular_Controller_2D : MonoBehaviour
{
    //=-----------------=
    // Public Variables
    //=-----------------=
    public float angularSpeed;
    [SerializeField] private bool invertRotationalAxis;


    //=-----------------=
    // Private Variables
    //=-----------------=
    private float angularVelocity;
    
    
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
	    if (invertRotationalAxis) angularVelocity *= -1;

	    // Update object position
	    var rotation = angularVelocity * Time.deltaTime;
	    transform.Rotate(0,0, rotation);
    }

    //=-----------------=
    // Internal Functions
    //=-----------------=
    private void UserInput()
    {
	    // Horizontal
	    if (Input.GetButton("RotateLeft")) angularVelocity = angularSpeed;
	    else if (Input.GetButton("RotateRight")) angularVelocity = -angularSpeed;
	    else angularVelocity = 0;
    }
    
    
    //=-----------------=
    // External Functions
    //=-----------------=
}