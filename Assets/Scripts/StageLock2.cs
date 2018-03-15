using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageLock2 : MonoBehaviour {
	GameObject button;

	// Use this for initialization
	void Start () {
		button = GameObject.Find ("Button2");
	}
	// Update is called once per frame
	void Update () {
		if (Goal.clearChecked)
			button.SetActive (true);
		else
			button.SetActive (false);
	}
}
