using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageLock : MonoBehaviour {
	GameObject stage;

	// Use this for initialization
	void Start () {
		stage = GameObject.Find ("lock");
	}
	// Update is called once per frame
	void Update () {
		if (Goal.clearChecked)
			stage.SetActive (false);
		else
			stage.SetActive (true);
	}
}
