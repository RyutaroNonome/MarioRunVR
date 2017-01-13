using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RayManager : MonoBehaviour {

	public GameObject diveCamera;
	public Image buttonGauge;
	public int endPositionX = -4;
	float gaugeTime;
	Vector3 firstButtonGaugePosition;
	LineRenderer linerenderer;

	void Start () {
		firstButtonGaugePosition = buttonGauge.transform.localPosition;
		linerenderer = GetComponent<LineRenderer> ();
	}

	void Update () {
		Ray ray = new Ray (diveCamera.transform.position, diveCamera.transform.forward);
		RaycastHit hit;

		linerenderer.SetPosition (0, transform.position);

		if (Physics.Raycast (ray, out hit)) {
			Debug.DrawLine (ray.origin, hit.point, Color.black);

			if (hit.transform.name == "Main" || hit.transform.name == "Kuppa") {
				gaugeTime += Time.deltaTime * 0.01f;
				buttonGauge.rectTransform.localPosition = Vector3.Lerp (buttonGauge.rectTransform.localPosition, new Vector3 (1400, 0, 1), gaugeTime);
			} else {
				gaugeTime = 0;
				buttonGauge.rectTransform.localPosition = firstButtonGaugePosition;
			}
			if (buttonGauge.rectTransform.localPosition.x > 0) {
				SceneManager.LoadScene (hit.transform.name);
			}
		}
		linerenderer.SetPosition (1, ray.origin + ray.direction * 100f);
	}
}