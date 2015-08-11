using UnityEngine;
using System.Collections;

public class SlowMotion : MonoBehaviour {

	public ParticleSystem frost;
	public ParticleSystem lightning;
	public Animator cameraControl;

	void Update() {
		if (Input.GetKeyDown(KeyCode.A)) {
			if (Time.timeScale == 1.0F){
				Time.timeScale = 0.1F;
				Debug.Log("SLOWMOTION");
			}
			Time.fixedDeltaTime = 0.02F * Time.timeScale;
		}

		if (Input.GetKeyDown (KeyCode.P)) {
			frost.Play ();
			Debug.Log ("FROST");
		}

		if (Input.GetKeyDown (KeyCode.L)) {
			lightning.Play();
			Debug.Log ("LIGHTNING");
		}

		if (Input.GetKeyDown (KeyCode.Z)) {
			cameraControl.enabled = true;
		}

		if (Input.GetKeyDown (KeyCode.X)) {
			cameraControl.enabled = false;
		}
	}
}

