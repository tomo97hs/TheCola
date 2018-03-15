using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCola : MonoBehaviour {

	float inputHorizontal;
	float inputVertical;
	Rigidbody rb;

	public CollisionCheck collisionCheck;
	public float moveSpeed = 5f;
	bool touchCheck = false;
	bool floorCheck = false;
	bool jumppingFlug = true;



	//GameObject Player;
	int horizon;
	int vertical;

	void Start() {
		rb = GetComponent<Rigidbody>();
	}

	void Update() {
		inputHorizontal = Input.GetAxisRaw("Horizontal");
		inputVertical = Input.GetAxisRaw("Vertical");



		if (Input.GetButtonDown ("Jump")) {
			if (jumppingFlug) {
				Jump ();
			}
		}

		touchCheck = collisionCheck.GetTouchChecked ();
		floorCheck = collisionCheck.GetFloorChecked ();
	}

	void FixedUpdate() {
		// カメラの方向から、X-Z平面の単位ベクトルを取得
		Vector3 cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 1)).normalized;
		// 方向キーの入力値とカメラの向きから、移動方向を決定
		Vector3 moveForward = cameraForward * inputVertical + Camera.main.transform.right * inputHorizontal;

			
		// 移動方向にスピードを掛ける。ジャンプや落下がある場合は、別途Y軸方向の速度ベクトルを足す。
		rb.velocity = moveForward * moveSpeed + new Vector3(0, rb.velocity.y, 0);

		// キャラクターの向きを進行方向に
		if (moveForward != Vector3.zero) {
			transform.rotation = Quaternion.LookRotation(moveForward);
		}

		if (floorCheck == false && touchCheck) {
//			print (jumppingFlug);
//			print (touchCheck);
			rb.velocity = new Vector3 (0, rb.velocity.y, 0);
		}
	}

	void Jump() {
		jumppingFlug = false;
		rb.AddForce (Vector3.up * 400);
		//rb.velocity = new Vector3(0, 10, 0);
		rb.AddForce (Vector3.down * 200, ForceMode.Acceleration);

	}

	void OnTriggerEnter(Collider col) {
		jumppingFlug = true;
	}

	IEnumerator sleep(){
		yield return new WaitForSeconds(3);  //3秒待つ
	}
}

