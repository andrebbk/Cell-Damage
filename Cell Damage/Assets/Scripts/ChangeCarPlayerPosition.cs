using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCarPlayerPosition : MonoBehaviour {

	bool _flag = false;

	void Update()
	{
		if(_flag)
			GetComponent<Rigidbody> ().isKinematic = false;
	}

	public void ChangePositionFor(Vector3 spawnPos, GameObject spawnRot)
	{
		_flag = false;
		GetComponent<Rigidbody> ().isKinematic = true;
		StartCoroutine (MudarFlag ());
		transform.position = spawnPos;
		transform.rotation = spawnRot.transform.rotation;
		GetComponent<Rigidbody>().velocity = Vector3.zero;
		GetComponent<Rigidbody>().angularVelocity = Vector3.zero;


	}


	IEnumerator MudarFlag()
	{
		yield return new WaitForSeconds (1);
		_flag = true;
	}
}
