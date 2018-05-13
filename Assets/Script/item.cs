using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class item : MonoBehaviour {

	public float items1;//アイテム指定用
	public float items2;
	public float items3;
	int items1a;//アイコン変更用
	int items2a;
	int items3a;
	GameObject icon1;

	public GameObject punch;//a:近距離
	public GameObject kick;

	// Use this for initialization
	void Start () {
		icon1 = punch;
		Instantiate (icon1, transform.position, transform.rotation);
	}
	
	// Update is called once per frame
	void Update () {
		//以下アイテム使用後の変更１
		if (Input.GetKeyDown(KeyCode.Slash)){
			items1 = Random.Range (1.0f, 10.0f);
			items1a = 1;
			Debug.Log (items1);
			//ここでdestroyで消せたら本望
		}


		//以下アイコン表示１
		if (items1a == 1 && 1.0f <= items1 && items1 < 5.0f) {
			icon1 = punch;
			Debug.Log (11);
			items1a = 2;
		}
		if (items1a == 1 && 5.0f <= items1 && items1 < 10.0f) {
			icon1 = kick;
			Debug.Log (11.2);
			items1a = 2;
		}




		if (items1a == 2) {
			Instantiate (icon1, transform.position, transform.rotation);
			items1a = 3;
			Debug.Log(12);
		}






	}


}
