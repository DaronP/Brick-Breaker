using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject objeto;

	// Use this for initialization
	void Start () 
	{


	}

	// Update is called once per frame
	void FixedUpdate () 
	{
		Spawn ();

	}

	void Spawn()
	{
		if (Input.GetKeyUp (KeyCode.R)) {
			Vector3 pos = new Vector3 (0.34f, 2.227528f, -2.215991f);
			Instantiate (objeto, pos, Quaternion.identity);

			float ex = Random.Range (0, 2) == 0 ? -1 : 1;
			float ey = Random.Range (0, 2) == 0 ? -1 : 1;

			objeto.GetComponent<Rigidbody2D> ().velocity = new Vector3 (Random.Range (2, 6) * ex, Random.Range (2, 6) * ey, 0);

		}

	}

}
