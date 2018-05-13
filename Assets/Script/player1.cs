using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class player1 : MonoBehaviour {

	float speed = 5.0f; //ここの数値は仮
	float jump = 8.0f;
	float down = 0.0f;


	item script;
	float item1 = 1.0f;//アイテム指定用
	public GameObject punch;

	bool touch;//床との接地判定

	// Use this for initialization
	void Start () {
		int charaNumber;
		//キャラクター番号を取ってくる

		//キャラクターごとに設定する
		
	}
	
	// Update is called once per frame
	void Update () {

		//移動
		if (Input.GetKey (KeyCode.RightArrow)) {
			GetComponent<Rigidbody2D> ().velocity =
				new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);
		}

		if (Input.GetKey(KeyCode.LeftArrow)){
			GetComponent<Rigidbody2D> ().velocity =
				new Vector2 (-speed, GetComponent<Rigidbody2D> ().velocity.y);
		}

		if ((Input.GetKey(KeyCode.UpArrow)) && (touch == true)){
			GetComponent<Rigidbody2D> ().velocity =
				new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jump);
			Debug.Log (1);//壁から離れるとジャンプできなくなる
		}

		if (Input.GetKey(KeyCode.DownArrow)){
			GetComponent<Rigidbody2D> ().velocity =
				new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, down);
		}



		//攻撃
		if (Input.GetKeyDown(KeyCode.Slash) && 1.0f <= item1 && item1 < 5.0f){
			Instantiate (punch, transform.position, transform.rotation);
			item1 = script.items1;
			Debug.Log (item1 + 2);
		}
	}

	void OnCollisionEnter2D (Collision2D other){
		if (other.gameObject.name == "floor") {
			touch = true;
			Debug.Log (2);
		}
	}

	void OnCollisionExit2D (Collision2D other){
		if (other.gameObject.name == "floor") {
			touch = false;
			Debug.Log (3);
		}
	}
		
}
