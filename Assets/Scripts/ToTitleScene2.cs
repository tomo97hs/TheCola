using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class ToTitleScene2 : MonoBehaviour {

	public Goal_stage2 goal;
	public ChangeCola gameOver;
	public GameObject parent;
	bool clearCheck;
	bool gameOverCheck;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {
		clearCheck = goal.GetClearChecked();
		gameOverCheck = gameOver.GetGameOverChecked();
		if (parent.activeSelf == false) {
			if (clearCheck) {
				if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown (0))
					SceneManager.LoadScene ("Stage Select Scene");
			}
			if (gameOverCheck) {
				if (Input.GetKeyDown (KeyCode.Space) || Input.GetMouseButtonDown(0))
					SceneManager.LoadScene ("Title Scene");
			}
		}
	}
}
