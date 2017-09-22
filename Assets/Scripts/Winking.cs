using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Winking : MonoBehaviour {

	double accumulatedTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		accumulatedTime += Time.deltaTime;

		if (accumulatedTime < 0.3) {
			this.gameObject.GetComponent<Renderer> ().enabled = true;
		} else if (accumulatedTime < 0.7) {
			this.gameObject.GetComponent<Renderer> ().enabled = false;
		} else {
			accumulatedTime = 0.0;
		}
	}
}
