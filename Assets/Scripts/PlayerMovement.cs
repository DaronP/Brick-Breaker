using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	private float deltaMovement = 6f;

	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		Movimiento ();

	}

	void Movimiento ()
	{

		if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
			transform.Translate(Vector3.left * deltaMovement * Time.deltaTime);
		else if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
			transform.Translate(Vector3.right * deltaMovement * Time.deltaTime);
	}
}
