using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBlade : MonoBehaviour {

	public float speed = 50f;

	// Update is called once per frame
	void Update () {
		transform.Rotate((0),(0),(-90f) * (speed * Time.deltaTime));
	}
}
