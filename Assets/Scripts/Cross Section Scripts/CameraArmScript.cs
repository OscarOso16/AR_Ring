using UnityEngine;
using System.Collections;

public class CameraArmScript : MonoBehaviour {

	public float _deltaRotation;

	
	// Update is called once per frame
	void Update () {
		if (_deltaRotation != 0.0f) {
			Vector3 rotation = new Vector3 (0.0f, (_deltaRotation * Time.deltaTime), 0.0f);
			transform.Rotate (rotation);
		}
	}

	public void SetDeltaRotation(float val){
		if (val < 1.0f && val > -1.0f)
			val = 0.0f;
		
		_deltaRotation = val;
	}
}
