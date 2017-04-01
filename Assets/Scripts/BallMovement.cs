using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour {

	float ex;
	float ey;

	// Use this for initialization
	void Start () 
	{
		ex = Random.Range (0, 2) == 0 ? -1 : 1;
		ey = Random.Range (0, 2) == 0 ? -1 : 1;

		GetComponent<Rigidbody2D> ().velocity = new Vector3 (Random.Range (2, 6) * ex, Random.Range (2, 6) * ey, 0);
	}

	// Update is called once per frame
	void FixedUpdate () 
	{




	}
}
