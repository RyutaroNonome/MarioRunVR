using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public static int score = 0;
	public static int timer = 180;
	float time = 0.0f;
	// Use this for initialization
	void Start () {
		StartCoroutine ("CountDownTime");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator CountDownTime(){
		yield return new WaitForSeconds (1.0f);
		timer -= 1;
		StartCoroutine ("CountDownTime");
	}
}
