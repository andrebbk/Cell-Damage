using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunsLooking : MonoBehaviour {	

	void LateUpdate() {
		Vector3 fwd = Camera.main.transform.forward;
		fwd.y = 0;

		if (fwd.sqrMagnitude != 0.0f) {
			fwd.Normalize();
			transform.LookAt(transform.position + fwd);
		}
	}
}
