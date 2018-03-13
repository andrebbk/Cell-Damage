using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveBoost : MonoBehaviour {

	public string boostButton;

	void Update()
	{
		if(Input.GetButton(boostButton))
		{			
				GetComponent<Rigidbody>().AddForce(transform.forward * 20, ForceMode.Acceleration);
		}
	}
	
}
