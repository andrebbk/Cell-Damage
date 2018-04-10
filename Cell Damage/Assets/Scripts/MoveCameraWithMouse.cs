using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCameraWithMouse : MonoBehaviour {
	
	public float mouseSensitivity = 100.0f;
	public float clampAngle = 80.0f;

	private float rotY = 0.0f; // rotation around the up/y axis
	private float rotX = 0.0f; // rotation around the right/x axis

	private Vector3 tmpMousePosition;

	void Start ()
	{
		Vector3 rot = transform.localRotation.eulerAngles;
		rotY = rot.y;
		rotX = rot.x;

		//Primeira posicao do rato
		tmpMousePosition = Input.mousePosition;
	}

	void Update ()
	{
		
		float mouseX = Input.GetAxis("Mouse X");
		float mouseY = -Input.GetAxis("Mouse Y");

		rotY += mouseX * mouseSensitivity * Time.deltaTime;
		rotX += mouseY * mouseSensitivity * Time.deltaTime;

		if (rotX < -21)
			rotX = -21;

		rotX = Mathf.Clamp(rotX, -clampAngle, clampAngle);
		
		Quaternion localRotation = Quaternion.Euler(rotX, rotY, 0.0f);
		transform.rotation = localRotation;




	}


}
