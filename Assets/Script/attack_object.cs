using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attack_object : MonoBehaviour {
	

	GameObject HP1;

	// Use this for initialization
	void Start () {
		Destroy (gameObject, 3);
		HP1 = GameObject.Find("HP1");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.name == "player1") {
			HP1.transform.position += new Vector3 (-0.8f, 0, 0);
		}

	}
}
