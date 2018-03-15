using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionCheck : MonoBehaviour {

	public ChangeCola changeCola;
	private bool colChecked = false; //衝突しているかどうか
	private bool touchChecked = false;
	private bool floorChecked = false;

	public bool GetColChecked(){
		return colChecked;
	}

	public bool GetTouchChecked(){
		return touchChecked;
	}

	public bool GetFloorChecked(){
		return floorChecked;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (changeCola.GetFallChecked () == false)
			touchChecked = false;
	}

	void OnCollisionEnter(Collision collision){
		string yourTag = collision.gameObject.tag;

		/* 衝突したもののタグがshelfだったら衝突検知 */
		if (yourTag == "shelf") {
			colChecked = true;
		}
		StartCoroutine ("sleep");
	}


	void OnCollisionStay(Collision col){
		/* "wall"のタグに触れている間 */
		if (col.gameObject.tag == "wall")
			touchChecked = true;
		/* "floor"のタグに触れている間 */
		if (col.gameObject.tag == "floor")
			floorChecked = true;
	}

	void OnCollisionExit(Collision col){
		if (col.gameObject.tag == "wall")
			touchChecked = false;
		if (col.gameObject.tag == "floor")
			floorChecked = false;
	}



	IEnumerator sleep(){
		yield return null;  //1フレーム待つ
		colChecked = false;
	}

	IEnumerator sleep2(){
		yield return new WaitForSeconds (0.5f);  //3秒待つ
		touchChecked = false;
	}
}
