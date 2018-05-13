using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class hp1 : MonoBehaviour {
	bool a;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (a == true) {
			SceneManager.LoadScene("Result2");
		}
	}

	void OnCollisionEnter2D (Collision2D other){
		a = true;
	}
}
