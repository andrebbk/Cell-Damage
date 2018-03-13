using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingRedGun : MonoBehaviour {

	public GameObject bulletPrefab;
	public Transform bulletSpawn;

	void Update()
	{	
		if (Input.GetKeyDown(KeyCode.Mouse0))
		{
			Fire();
		}
	}


	void Fire()
	{
		// Create the Bullet from the Bullet Prefab
		var bullet = (GameObject)Instantiate(
			bulletPrefab,
			bulletSpawn.position,
			Camera.main.transform.rotation);

		// Add velocity to the bullet
		bullet.GetComponent<Rigidbody>().velocity = bullet.transform.forward * 200;

		// Destroy the bullet after 2 seconds
		Destroy(bullet, 2.0f);        
	}
}
