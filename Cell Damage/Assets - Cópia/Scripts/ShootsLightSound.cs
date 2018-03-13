using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootsLightSound : MonoBehaviour {

	GameObject _muzzle;
	GameObject _fumoGun;

	public GameObject bulletPrefab;
	public Transform bulletSpawn;
	private float nextFire = 0f;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < transform.childCount; i++)
		{
			Transform child = transform.GetChild(i);

			if (child.tag == "Muzzle")
			{
				_muzzle = child.gameObject;
				_muzzle.SetActive(false);	
			}

			if (child.tag == "fumoGun")
			{
				_fumoGun = child.gameObject;
				_fumoGun.SetActive(false);
			}
		}

		nextFire = 0f;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Mouse0))
		{
			_muzzle.SetActive(true);

			if (Time.time > nextFire) 
			{				
				Fire();
				//5 segundos acho entre balas
				nextFire = Time.time + 0.15f;
			}
				
		}else
		{
			_muzzle.SetActive(false);	
		}

		if (Input.GetKeyUp (KeyCode.Mouse0)) 
		{
			StartCoroutine (ShowSmoke());
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
		//Destroy(bullet, 2.0f);        
	}

	IEnumerator ShowSmoke() {
		_fumoGun.SetActive(true);
		yield return new WaitForSeconds (2);
		_fumoGun.SetActive(false);
	}
}
