using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class Goal : MonoBehaviour {
	public Text clearText;
	GameObject game_object;
	public static bool clearChecked = false; //ステージクリアしているかを判断する

	public bool GetClearChecked(){
		return clearChecked;
	}

	// Use this for initialization
	void Start () {
		game_object = GameObject.Find("Cola Can");
	}
	
	// Update is called once per frame
	void Update () {
		if ((transform.position.x >= 0.09 && transform.position.x <= 0.29) && (transform.position.z >= 1.288 && transform.position.z <= 1.428)) {
			clearChecked = true;
			clearText.enabled = true;
			game_object.SetActive (false);
		}
	}
}
