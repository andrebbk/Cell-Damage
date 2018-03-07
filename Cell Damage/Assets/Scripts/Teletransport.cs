using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransport : MonoBehaviour {

	public GameObject _Target;

	void OnTriggerEnter(Collider col) {

		GameObject Pla = GameObject.FindGameObjectWithTag("carroPlayer");

		if (col.gameObject.name == Pla.name) 
		{
			Pla.GetComponent<ChangeCarPlayerPosition>().ChangePositionFor(_Target.transform.position, _Target);
		}

	}

}
