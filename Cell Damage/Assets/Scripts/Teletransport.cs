using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransport : MonoBehaviour {

	public GameObject _Target;

	void OnTriggerEnter(Collider col) {

		if (col.gameObject.tag == "carroPlayer" || col.gameObject.tag == "carros") 
		{
			col.gameObject.GetComponent<ChangeCarPlayerPosition>().ChangePositionFor(_Target.transform.position, _Target);
		}

	}

}
