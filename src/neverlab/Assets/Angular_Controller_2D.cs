//========== Neverway 2022 Project Script | Written by Unknown Dev ============

using UnityEngine;

public class Angular_Controller_2D : MonoBehaviour
{
    //=-----------------=
    // Public Variables
    //=-----------------=
    public float speed;
    [SerializeField] private bool invertRotationalAxis;


    //=-----------------=
    // Private Variables
    //=-----------------=
    private Vector3 angularVelocity;
    
    
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
	    if (invertRotationalAxis) angularVelocity.z *= -1;

	    // Update object position
	    transform.Rotate(angularVelocity * Time.deltaTime);
    }

    //=-----------------=
    // Internal Functions
    //=-----------------=
    private void UserInput()
    {
	    // Horizontal
	    if (Input.GetButton("RotateLeft")) angularVelocity.z = speed;
	    else if (Input.GetButton("RotateRight")) angularVelocity.z = -speed;
	    else angularVelocity.z = 0;
    }
    
    
    //=-----------------=
    // External Functions
    //=-----------------=
}