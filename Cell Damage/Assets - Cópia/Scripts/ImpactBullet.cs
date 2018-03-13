using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImpactBullet : MonoBehaviour {

	void Start()
	{
		//Senao bater em nenhum collider destroir bala
		StartCoroutine(DesBala());
	}

	void OnTriggerEnter(Collider col)
	{
		Destroy (this.gameObject);
	}

	IEnumerator DesBala() {
		yield return new WaitForSeconds (3);
		Destroy (this.gameObject);
	}
}
