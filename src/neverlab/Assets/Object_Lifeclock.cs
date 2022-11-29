//========== Neverway 2022 Project Script | Written by Unknown Dev ============
// 
// Purpose: Destroy a newly created gameObject once a duration of time has passed 
// Applied to: Any temporary gameObject
// Notes: Please remember that a lifetime of 0 will cause the object to be immediately
//         destroyed
//
//=============================================================================

using UnityEngine;

public class Object_Lifeclock : MonoBehaviour
{
    //=-----------------=
    // Public Variables
    //=-----------------=
    [Tooltip("Seconds until the object is destroyed")]
    public float lifetime;


    //=-----------------=
    // Private Variables
    //=-----------------=
    
    
    //=-----------------=
    // Reference Variables
    //=-----------------=


    //=-----------------=
    // Mono Functions
    //=-----------------=
    private void Start()
    {
		Destroy(gameObject, lifetime);
    }
    
    
    //=-----------------=
    // Internal Functions
    //=-----------------=
    
    
    //=-----------------=
    // External Functions
    //=-----------------=
}

