using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ParamScript: MonoBehaviour {

	public Text text1;
	public Text text2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		text1.text = "スコア：" + GameManager.score;
		text2.text = "残り時間：" + GameManager.timer;
	}


}
