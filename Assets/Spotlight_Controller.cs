using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spotlight_Controller : MonoBehaviour {
    public GameObject light;

	// Update is called once per frame
	void Update () {
        light.transform.position = this.transform.position;
        light.transform.rotation = this.transform.rotation;
	}
}
