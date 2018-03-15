using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class Goal_stage2 : MonoBehaviour {
	public Text clearText;
	GameObject game_object;
	private bool clearChecked = false; //ステージクリアしているかを判断する

	public bool GetClearChecked(){
		return clearChecked;
	}

	// Use this for initialization
	void Start () {
		game_object = GameObject.Find("Cola Can");
	}

	// Update is called once per frame
	void Update () {
		if ((transform.position.x >= 4.23 && transform.position.x <= 4.43) && (transform.position.z >= -0.44 && transform.position.z <= -0.24)) {
			clearChecked = true;
			clearText.enabled = true;
			game_object.SetActive (false);
		}
	}
}
