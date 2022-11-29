//========== Neverway 2022 Project Script | Written by Unknown Dev ============
// 
// Purpose: Spawn a target object at specified position moving at a set speed
// Applied to: The object that creates a projectile (like a gun or turret)
// Notes: Projectiles move in their transform.forward (+Y for 2D, +Z for 3D)
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
    [SerializeField] private float projectileSpeed;


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
	    var projectile = Instantiate(projectilePrefab, spawnTransform.position, spawnTransform.rotation);
	    var projectileRigidbody = projectile.GetComponent<Rigidbody2D>();
	    if (projectileRigidbody) projectileRigidbody.AddForce(transform.up*projectileSpeed,ForceMode2D.Force);
    }
}

