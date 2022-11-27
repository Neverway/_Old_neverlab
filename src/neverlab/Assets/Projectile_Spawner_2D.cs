//========== Neverway 2022 Project Script | Written by Unknown Dev ============
// 
// Purpose: 
// Applied to: 
// Editor script: 
// Notes: 
//
//=============================================================================

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile_Spawner_2D : MonoBehaviour
{
    //=-----------------=
    // Public Variables
    //=-----------------=


    //=-----------------=
    // Private Variables
    //=-----------------=
    
    
    //=-----------------=
    // Reference Variables
    //=-----------------=
    [SerializeField] private GameObject projectilePrefab;
    [SerializeField] private Transform spawnTransform;


    //=-----------------=
    // Mono Functions
    //=-----------------=
    private void Start()
    {
	
    }

    private void Update()
    {
	    if (Input.GetKeyDown(KeyCode.Space))
	    {
		    SpawnProjectile();
	    }
    }
    
    //=-----------------=
    // Internal Functions
    //=-----------------=
    
    
    //=-----------------=
    // External Functions
    //=-----------------=
    public void SpawnProjectile()
    {
	    Instantiate(projectilePrefab, spawnTransform.position, spawnTransform.rotation);
    }
}

