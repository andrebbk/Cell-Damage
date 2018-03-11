using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGunSound : MonoBehaviour {

	AudioSource _Source;

	void Start()
	{
		_Source = GetComponent<AudioSource> ();
		_Source.Stop ();
	}
	void Update () {
		if(Input.GetKey(KeyCode.Mouse0))
		{
			if(!_Source.isPlaying)
				_Source.Play ();

		}else
		{
			_Source.Stop ();
		}
	}
}
