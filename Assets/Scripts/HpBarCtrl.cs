using UnityEngine;
using System.Collections;
using UnityEngine.UI; 

public class HpBarCtrl: MonoBehaviour {

	public ChangeCola life;
	Slider _slider;
	int colaLife;

	void Start () {
		// スライダーを取得する
		_slider = GameObject.Find("HpBarCtrl").GetComponent<Slider>();
	}
	
	void Update(){
		colaLife = life.GetColaLife ();
		//print (colaLife);
		_slider.value = colaLife;
		if(colaLife == 0)
			_slider.fillRect.localScale = new Vector3 (0, 0, 0);
	}

}
