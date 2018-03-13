using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonANim : MonoBehaviour {


	private Animator animator;
	public GameObject _carro;
	public GameObject _Pai;

	bool _flag = false;

	void Start () {
		animator = GetComponent<Animator> ();
		_flag = false;
	}

	void OnTriggerEnter(Collider col)
	{
		if (col.gameObject.tag == "carroPlayer")
		{
			_flag = true;
			animator.SetTrigger ("Fire");
		}
	}

	void OnTriggerExit(Collider col2)
	{
		if (col2.gameObject.tag == "carroPlayer")
		{
			_flag = false;
			animator.SetTrigger ("Idle");
		
		}
	}

	void Update() {

		if (_flag) {
			
			//Rotação de forma suave
			var rotation = Quaternion.LookRotation (_carro.transform.position - _Pai.transform.position);
			_Pai.transform.rotation = Quaternion.Slerp (_Pai.transform.rotation, rotation, Time.deltaTime * 6.0f);

		}

	}
}
