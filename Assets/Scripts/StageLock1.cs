using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageLock1 : MonoBehaviour {
	GameObject stageName;

	// Use this for initialization
	void Start () {
		stageName = GameObject.Find ("stageName2");
	}
	// Update is called once per frame
	void Update () {
		if (Goal.clearChecked)
			stageName.SetActive (true);
		else
			stageName.SetActive (false);
	}
}
