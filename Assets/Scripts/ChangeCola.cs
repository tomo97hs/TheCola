using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeCola : MonoBehaviour {

	private AudioSource sound01;
	public CollisionCheck collisionCheck;
	public Text gameOverText;
	GameObject cola;
	GameObject fallCola;
	Vector3 pos;
	bool colCheck; // 衝突しているかどうか
	bool fallChacked = true; // 倒れているかどうか
	bool gameOverChecked = false; // game overかどうか
	bool oneTime = true;
	int colaLife = 3; // コーラのライフ3

	public bool GetGameOverChecked(){
		return gameOverChecked;
	}

	public bool GetFallChecked(){
		return fallChacked;
	}

	public int GetColaLife(){
		return colaLife;
	}
		

	// Use this for initialization
	void Start () {
		sound01 = GetComponent<AudioSource>();
		cola = GameObject.Find ("Cola/Cola Can");
		fallCola = GameObject.Find ("Cola/fallCola");
		fallCola.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
		colCheck = collisionCheck.GetColChecked (); // 衝突検知
		
		if (colCheck) {
			if (fallChacked) {
				
				cola.SetActive (false);
				if (oneTime)
					sound01.PlayOneShot(sound01.clip);

				if (--colaLife == 0) {
					oneTime = false;
			    	fallCola.transform.position = cola.transform.position;
					fallCola.SetActive (true);
					gameOverText.enabled = true;
					//cola.SetActive (false);
					gameOverChecked = true;
				}
					
				/* game overじゃなかったら */
				if (gameOverChecked == false) {
					/* fallColaをCola Canの0.5上の位置に配置 */
					pos = cola.transform.position;
					pos.y += 0.5f;
					fallCola.transform.position = pos;
					fallCola.SetActive (true);

					StartCoroutine ("sleep");
					fallChacked = false;
					colCheck = false;
				}

			}
		} else {
			fallChacked = true;
			fallCola.SetActive (false);
		}
	}

	IEnumerator sleep(){
		sound01 = GetComponent<AudioSource>();
		yield return new WaitForSeconds(3);  //3秒待つ
		cola.transform.localPosition = new Vector3(4.712909f, 1.11322f, -1.313405f);
		/*
		cola.transform.position.x = 4.712909;
		cola.transform.position.y = 1.11322;
		cola.transform.position.z = -1.313405;
		*/
		cola.SetActive (true);
		fallCola.SetActive (false);
	}

}
