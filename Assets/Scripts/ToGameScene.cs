using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;//シーンマネジメントを有効にする

public class ToGameScene : MonoBehaviour {
	//private AudioSource titleSound;

	void Start () {
		//titleSound = GetComponent<AudioSource>();
	}
	// Update is called once per frame
	void Update ()
	{
		if (Input.GetMouseButtonDown(0) || Input.GetKeyDown("space")) //マウス左クリック、スペースキー、Aボタン、ジャンプボタンを押した場合
		{
			//titleSound.PlayOneShot(titleSound.clip);
			SceneManager.LoadScene("Stage Select Scene");//some_senseiシーンをロードする

		}

	}
}
