using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCrossHair : MonoBehaviour {

	public float speed = 5.0f;
	public Texture2D CrosshairTexture;

	void start()
	{
		//Set Cursor to not be visible
		//Cursor.visible = false;
	}

	void Update()
	{
//		var x = Input.GetAxis ("Horizontal") * Time.deltaTime * speed;
//		var z = Input.GetAxis ("Vertical") * Time.deltaTime * speed;
//		var Y = Input.GetAxis ("Jump") * Time.deltaTime * speed;


		Vector3 mouseVector = Input.mousePosition;
		mouseVector  = Camera.main.ScreenToWorldPoint(mouseVector);
		Debug.Log(mouseVector);
		transform.Translate (mouseVector);

	}

	void OnGUI ()
	{
		var vectorx = Input.mousePosition.x;
		var vectory = Input.mousePosition.y;
		GUI.DrawTexture (new Rect(vectorx-15f, -vectory + Screen.height -15f, 30f, 30f), CrosshairTexture);
	}
}
