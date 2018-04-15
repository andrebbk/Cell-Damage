using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBlade : MonoBehaviour {

	float speed = 100f;

	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.Mouse0)) {
			transform.Rotate ((0), (0), (-90f) * (speed * Time.deltaTime));
		}
	}

}
