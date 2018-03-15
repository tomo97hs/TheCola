using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour {
	GameObject targetObj;
	Vector3 targetPos;

	void Start () {
		targetObj = GameObject.Find("Cola Can");
		targetPos = targetObj.transform.position;
	}

	void Update() {
		// targetの移動量分、自分（カメラ）も移動する
		transform.position += targetObj.transform.position - targetPos;
		targetPos = targetObj.transform.position;

		// マウスの右クリックを押している間

		if (Input.GetMouseButton (1)) {
			// マウスの移動量
			float mouseInputX = Input.GetAxis ("Mouse X");
			transform.RotateAround(targetPos, Vector3.up, mouseInputX * Time.deltaTime * 200f);

		}
		/*
		if (Input.GetKey(KeyCode.RightArrow)){
			float rightArrow = Input.GetAxis("Horizontal");
			//float mouseInputY = Input.GetAxis("Mouse Y");
			// targetの位置のY軸を中心に、回転（公転）する
			transform.RotateAround(targetPos, Vector3.up, rightArrow * Time.deltaTime * 200f);
			// カメラの垂直移動（※角度制限なし、必要が無ければコメントアウト）
			//transform.RotateAround(targetPos, transform.right, mouseInputY * Time.deltaTime * 200f);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			float leftArrow = Input.GetAxis ("Horizontal");
			// targetの位置のY軸を中心に、回転（公転）する
			transform.RotateAround (targetPos, Vector3.up, leftArrow * Time.deltaTime * 200f);
		}
		*/
	}   
}