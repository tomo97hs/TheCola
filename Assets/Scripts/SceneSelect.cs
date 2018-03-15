using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class SceneSelect : MonoBehaviour {

	public void OnClick() {
		SceneManager.LoadScene("Game Scene");
	}

	public void OnClick2() {
		SceneManager.LoadScene("Stage2");
	}
}