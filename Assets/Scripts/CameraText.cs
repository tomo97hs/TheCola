using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement; 
using UnityEngine.UI;

public class CameraText : MonoBehaviour {
	public Text clearText;
	public Text gameOverText;

	// Use this for initialization
	void Start () {
		clearText.enabled = false;
		gameOverText.enabled = false;
	}

	// Update is called once per frame
	void Update () {
		
	}
}