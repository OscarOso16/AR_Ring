using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuadRotation : MonoBehaviour {
    public GameObject camara;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.rotation = camara.transform.rotation;
	}
}
