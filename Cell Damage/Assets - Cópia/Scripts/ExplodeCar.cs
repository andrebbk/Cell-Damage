using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeCar : MonoBehaviour {

	public ParticleSystem explosion;
	bool flag1 = false;
	public AudioClip impact;

	void Start() {
		StartCoroutine (MudarFlag());
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
