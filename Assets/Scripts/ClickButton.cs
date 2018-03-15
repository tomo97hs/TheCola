using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClickButton : MonoBehaviour {

	/// ボタンをクリックした時の処理
	public void OnClick1() {
		SceneManager.LoadScene ("Title Scene");
	}

	public void OnClick2() {
		SceneManager.LoadScene ("Game Scene");
	}

	public void OnClick3() {
		SceneManager.LoadScene ("Stage2");
	}

	public void OnClick4() {
		SceneManager.LoadScene ("Stage Select Scene");
	}

}
