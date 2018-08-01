using UnityEngine;
using System.Collections;

public class CrossSectionController : MonoBehaviour {

	private Renderer rend;
	public GameObject xMarker;
	public GameObject yMarker;
	public GameObject zMarker;

	private float xVal;
	private float yVal;
	private float zVal;
	private bool xActive = true;
	private bool yActive = true;
	private bool zActive = true;


	void Start(){
		rend = GetComponent<Renderer> ();

		SetClippingX (0.0f);
		SetClippingY (0.0f);
		SetClippingZ (0.0f);

		rend.material.SetFloat ("_DirectionX", -1.0f);
		rend.material.SetFloat ("_DirectionY", -1.0f);
		rend.material.SetFloat ("_DirectionZ", -1.0f);
	}

	public void SetClippingX(float val){
		rend.material.SetFloat ("_ClippingX", val);
		xVal = val;
		UpdateXMarker (xActive);
	}

	public void SetClippingY(float val){
		rend.material.SetFloat ("_ClippingY", val);
		yVal = val;
		UpdateYMarker (yActive);
	}

	public void SetClippingZ(float val){
		rend.material.SetFloat ("_ClippingZ", val);
		zVal = val;
		UpdateZMarker (zActive);
	}

	public void ReverseClippingX(bool isFlipped){
		float dir = 1.0f;

		if (isFlipped)
			dir = -1.0f;
		rend.material.SetFloat ("_DirectionX", dir);
	}

	public void ReverseClippingY(bool isFlipped){
		float dir = 1.0f;

		if (isFlipped)
			dir = -1.0f;
		rend.material.SetFloat ("_DirectionY", dir);
	}

	public void ReverseClippingZ(bool isFlipped){
		float dir = 1.0f;

		if (isFlipped)
			dir = -1.0f;
		rend.material.SetFloat ("_DirectionZ", dir);
	}

	public void UpdateXMarker(bool isActive){
		xActive = isActive;
		xMarker.SetActive (isActive);

		if (isActive) {
			Transform trans = xMarker.transform;
			trans.position = new Vector3 (xVal, trans.position.y, trans.position.z);
		}
	}

	public void UpdateYMarker(bool isActive){
		yActive = isActive;
		yMarker.SetActive (isActive);

		if (isActive) {
			Transform trans = yMarker.transform;
			trans.position = new Vector3 (trans.position.x, yVal, trans.position.z);
		}
	}

	public void UpdateZMarker(bool isActive){
		zActive = isActive;
		zMarker.SetActive (isActive);

		if (isActive) {
			Transform trans = zMarker.transform;
			trans.position = new Vector3 (trans.position.x, trans.position.y, zVal);
		}
	}
}
