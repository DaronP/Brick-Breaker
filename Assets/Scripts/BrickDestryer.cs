using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickDestryer : MonoBehaviour {
	public UIManager ui;

	// Use this for initialization
	void Start () 
	{
		ui = GameObject.FindWithTag ("ui").GetComponent<UIManager> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		if (col.gameObject.tag == "Ball") 
		{
			ui.Score ();
			Destroy (gameObject);

		}

	}
		
}
