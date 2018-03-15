using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour {
	GameObject toTitle;
	GameObject toSelect;
	GameObject reset;
	GameObject cancel;
	GameObject game_object;
	//Renderer rend;
	public GameObject parent;
	private bool isChecked = false;

	// Use this for initialization
	void Start () {
		toTitle = GameObject.Find ("Canvas/toTitleButton");
		toSelect = GameObject.Find ("Canvas/toSelectButton");
		reset = GameObject.Find ("Canvas/resetButton");
		cancel = GameObject.Find ("Canvas/cancelButton");
		game_object = GameObject.Find("Cola Can");
		toTitle.SetActive (false);
		toSelect.SetActive (false);
		reset.SetActive (false);
		cancel.SetActive (false);
		//rend = GetComponent<Renderer>(); 
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public bool GetIsChecked(){
		return isChecked;
	}

	/* メニュー */
	void OnGUI() {
		if (parent.activeSelf == true) {
			Rect rect1 = new Rect (10, 10, 70, 30);
			isChecked = GUI.Toggle (rect1, isChecked, "メニュー");

			//Rect rect2 = new Rect (10, 40, 400, 30);
			if (isChecked) {
				toTitle.SetActive (true);
				toSelect.SetActive (true);
				reset.SetActive (true);
				cancel.SetActive (true);
				game_object.GetComponent<Renderer>().enabled = false; 

			} else {
				toTitle.SetActive (false);
				toSelect.SetActive (false);
				reset.SetActive (false);
				cancel.SetActive (false);
				game_object.GetComponent<Renderer>().enabled = true;

			}
		}
	}

	public void OnClick() {
		isChecked = false;
		game_object.GetComponent<Renderer>().enabled = true; 
	}

}
