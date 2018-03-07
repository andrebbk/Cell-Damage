using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceBarrel : MonoBehaviour {

	public ParticleSystem explosion;
	bool flag1 = false;
	public AudioClip impact;

	void OnCollisionEnter(Collision other) {
		
		if (other.gameObject.tag == "carroPlayer") {
			// how much the character should be knocked back
			var magnitude = 10;
			// calculate force vector
			var force = transform.position - other.transform.position;
			// normalize force vector to get direction only and trim magnitude
			force.Normalize();
			GetComponent<Rigidbody>().AddForce(force * magnitude);

			StartCoroutine (MudarFlag());
		}
	}

	public void explodir()
	{
		AudioSource.PlayClipAtPoint (impact, transform.position);
		var expl = Instantiate(explosion, transform.position, Quaternion.identity);
		Destroy(this.gameObject);
		Destroy(expl, 3);
		flag1 = false;
	}		

	void Update()
	{
		if (flag1)
			explodir ();
	}

	IEnumerator MudarFlag()
	{
		yield return new WaitForSeconds(4);
		flag1 = true;
	}
}
