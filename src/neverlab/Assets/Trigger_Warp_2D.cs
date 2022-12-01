//========== Neverway 2022 Project Script | Written by Unknown Dev ============

using System;
using UnityEngine;

public class Trigger_Warp_2D : MonoBehaviour
{
    //=-----------------=
    // Public Variables
    //=-----------------=
    [SerializeField] private LayerMask targetMask;


    //=-----------------=
    // Private Variables
    //=-----------------=
    
    
    //=-----------------=
    // Reference Variables
    //=-----------------=
    [SerializeField] private Transform exitTarget;


    //=-----------------=
    // Mono Functions
    //=-----------------=

    private void OnTriggerEnter2D(Collider2D other)
    {
        if ((targetMask & (1 << other.gameObject.layer)) != 0)
        {
            other.transform.position = exitTarget.transform.position;
        }
    }


    //=-----------------=
    // Internal Functions
    //=-----------------=
    
    
    //=-----------------=
    // External Functions
    //=-----------------=
}