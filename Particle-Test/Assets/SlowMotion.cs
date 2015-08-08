using UnityEngine;
using System.Collections;

public class SlowMotion : MonoBehaviour {

	void Update() {
		if (Input.GetKeyDown(KeyCode.A)) {
			if (Time.timeScale == 1.0F){
				Time.timeScale = 0.1F;
				Debug.Log("SLOWMOTION");
			}
			//else
				//Time.timeScale = 1.0F;
			Time.fixedDeltaTime = 0.02F * Time.timeScale;
		}
	}
}

